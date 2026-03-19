/*
order: 30
title: Embedding Generator Custom Dimensions
slug: embedding-generator-custom-dimensions
*/

using Microsoft.Extensions.AI;

namespace Jina.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task EmbeddingGenerator_CustomDimensions()
    {
        using var client = GetAuthenticatedClient();

        IEmbeddingGenerator<string, Embedding<float>> generator = client;
        var embeddings = await generator.GenerateAsync(
            ["Hello, world!"],
            new EmbeddingGenerationOptions
            {
                ModelId = "jina-embeddings-v3",
                Dimensions = 256,
            });

        embeddings.Should().ContainSingle();
        embeddings[0].Vector.Length.Should().Be(256);
    }
}
