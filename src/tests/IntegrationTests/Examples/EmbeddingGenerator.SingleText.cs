/*
order: 70
title: Embedding Generator Single Text
slug: embedding-generator-single-text
*/

using Microsoft.Extensions.AI;

namespace Jina.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task EmbeddingGenerator_SingleText()
    {
        using var client = GetAuthenticatedClient();

        IEmbeddingGenerator<string, Embedding<float>> generator = client;
        var embeddings = await generator.GenerateAsync(
            ["Hello, world!"],
            new EmbeddingGenerationOptions
            {
                ModelId = "jina-embeddings-v3",
            });

        embeddings.Should().ContainSingle();
        embeddings[0].Vector.Length.Should().BeGreaterThan(0);
    }
}
