using Microsoft.Extensions.AI;

namespace Jina;

/// <summary>
/// Extension methods for generating multimodal embeddings (images, PDFs) using Jina v4.
/// </summary>
public static class JinaClientMultimodalExtensions
{
    /// <summary>
    /// Generates embeddings for one or more images using jina-embeddings-v4.
    /// </summary>
    /// <param name="client">The Jina client.</param>
    /// <param name="imageUrls">Image URLs or base64-encoded image strings.</param>
    /// <param name="options">Optional embedding generation options (ModelId, Dimensions).</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Generated embeddings for each image.</returns>
    [CLSCompliant(false)]
    public static async Task<GeneratedEmbeddings<Embedding<float>>> GenerateImageEmbeddingsAsync(
        this JinaClient client,
        IEnumerable<string> imageUrls,
        EmbeddingGenerationOptions? options = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(imageUrls);

        var images = imageUrls as IList<string> ?? imageUrls.ToList();

        var request = new EmbeddingsV4Request
        {
            Model = options?.ModelId ?? "jina-embeddings-v4",
            Input = images.Count == 1
                ? new AnyOf<string, TextDoc, ImageDoc, PDFDoc, IList<AnyOf<string, TextDoc, ImageDoc>>>(
                    new ImageDoc { Image = images[0] })
                : new AnyOf<string, TextDoc, ImageDoc, PDFDoc, IList<AnyOf<string, TextDoc, ImageDoc>>>(
                    images.Select(url => new AnyOf<string, TextDoc, ImageDoc>(
                        new ImageDoc { Image = url })).ToList()),
        };

        if (options?.Dimensions is { } dimensions)
        {
            request.Dimensions = dimensions;
        }

        return await ExecuteV4RequestAsync(client, request, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Generates an embedding for a PDF document using jina-embeddings-v4.
    /// PDFs must be processed individually (cannot be batched).
    /// </summary>
    /// <param name="client">The Jina client.</param>
    /// <param name="pdfUrl">PDF URL or base64-encoded PDF string.</param>
    /// <param name="options">Optional embedding generation options (ModelId, Dimensions).</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Generated embedding for the PDF.</returns>
    [CLSCompliant(false)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1054:URI-like parameters should not be strings")]
    public static async Task<GeneratedEmbeddings<Embedding<float>>> GeneratePdfEmbeddingAsync(
        this JinaClient client,
        string pdfUrl,
        EmbeddingGenerationOptions? options = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(pdfUrl);

        var request = new EmbeddingsV4Request
        {
            Model = options?.ModelId ?? "jina-embeddings-v4",
            Input = new AnyOf<string, TextDoc, ImageDoc, PDFDoc, IList<AnyOf<string, TextDoc, ImageDoc>>>(
                new PDFDoc { Pdf = pdfUrl }),
        };

        if (options?.Dimensions is { } dimensions)
        {
            request.Dimensions = dimensions;
        }

        return await ExecuteV4RequestAsync(client, request, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Generates embeddings for a mixed batch of text and images using jina-embeddings-v4.
    /// </summary>
    /// <param name="client">The Jina client.</param>
    /// <param name="items">Mixed content items to embed.</param>
    /// <param name="options">Optional embedding generation options (ModelId, Dimensions).</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Generated embeddings for each item.</returns>
    [CLSCompliant(false)]
    public static async Task<GeneratedEmbeddings<Embedding<float>>> GenerateMixedEmbeddingsAsync(
        this JinaClient client,
        IEnumerable<AnyOf<string, TextDoc, ImageDoc>> items,
        EmbeddingGenerationOptions? options = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(items);

        var itemList = items as IList<AnyOf<string, TextDoc, ImageDoc>> ?? items.ToList();

        var request = new EmbeddingsV4Request
        {
            Model = options?.ModelId ?? "jina-embeddings-v4",
            Input = new AnyOf<string, TextDoc, ImageDoc, PDFDoc, IList<AnyOf<string, TextDoc, ImageDoc>>>(itemList),
        };

        if (options?.Dimensions is { } dimensions)
        {
            request.Dimensions = dimensions;
        }

        return await ExecuteV4RequestAsync(client, request, cancellationToken).ConfigureAwait(false);
    }

    private static async Task<GeneratedEmbeddings<Embedding<float>>> ExecuteV4RequestAsync(
        JinaClient client,
        EmbeddingsV4Request request,
        CancellationToken cancellationToken)
    {
        var response = await client.SearchFoundationModels.EmbeddingsAsync(
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
