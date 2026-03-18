using Microsoft.Extensions.AI;

namespace Jina;

public partial class JinaClient : IEmbeddingGenerator<string, Embedding<float>>
{
    private EmbeddingGeneratorMetadata? _embeddingMetadata;

    object? IEmbeddingGenerator.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return
            serviceKey is not null ? null :
            serviceType == typeof(EmbeddingGeneratorMetadata) ? (_embeddingMetadata ??= new(nameof(JinaClient), BaseUri)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    async Task<GeneratedEmbeddings<Embedding<float>>> IEmbeddingGenerator<string, Embedding<float>>.GenerateAsync(
        IEnumerable<string> values,
        EmbeddingGenerationOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(values);

        var texts = values as IList<string> ?? values.ToList();

        var request = new EmbeddingsV3Request
        {
            Model = options?.ModelId ?? "jina-embeddings-v3",
            Input = texts.Count == 1
                ? new AnyOf<string, TextDoc, IList<AnyOf<string, TextDoc>>>(texts[0])
                : new AnyOf<string, TextDoc, IList<AnyOf<string, TextDoc>>>(
                    texts.Select(t => new AnyOf<string, TextDoc>(t)).ToList()),
        };

        if (options?.Dimensions is { } dimensions)
        {
            request.Dimensions = dimensions;
        }

        var response = await SearchFoundationModels.EmbeddingsAsync(
            request, cancellationToken).ConfigureAwait(false);

        var embeddings = new GeneratedEmbeddings<Embedding<float>>();

        if (response.Data.Value1 is { } singleEmbeddings)
        {
            foreach (var item in singleEmbeddings)
            {
                if (item.Embedding.Value2 is { } vector)
                {
                    var floatArray = new float[vector.Count];
                    for (var i = 0; i < vector.Count; i++)
                    {
                        floatArray[i] = (float)vector[i];
                    }

                    embeddings.Add(new Embedding<float>(floatArray)
                    {
                        ModelId = response.Model,
                    });
                }
            }
        }

        if (response.Usage.Value1 is { } usage)
        {
            embeddings.Usage = new UsageDetails
            {
                InputTokenCount = usage.PromptTokens,
                TotalTokenCount = usage.TotalTokens,
            };
        }

        return embeddings;
    }
}
