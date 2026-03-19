/*
order: 20
title: Embedding Generator Batch Texts
slug: embedding-generator-batch-texts
*/

using Microsoft.Extensions.AI;

namespace Jina.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task EmbeddingGenerator_BatchTexts()
    {
        using var client = GetAuthenticatedClient();

        IEmbeddingGenerator<string, Embedding<float>> generator = client;
        var embeddings = await generator.GenerateAsync(
            ["Hello", "World", "Test"],
            new EmbeddingGenerationOptions
            {
                ModelId = "jina-embeddings-v3",
            });

        embeddings.Should().HaveCount(3);
        foreach (var embedding in embeddings)
        {
            embedding.Vector.Length.Should().BeGreaterThan(0);
        }
    }
}
