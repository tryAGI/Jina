/*
order: 90
title: Multimodal Embeddings Single Image
slug: multimodal-embeddings-single-image
*/

using Microsoft.Extensions.AI;

namespace Jina.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task MultimodalEmbeddings_SingleImage()
    {
        using var client = GetAuthenticatedClient();

        var embeddings = await client.GenerateImageEmbeddingsAsync(
            ["https://i.ibb.co/nQNGqL0/beach1.jpg"],
            new EmbeddingGenerationOptions
            {
                Dimensions = 256,
            });

        embeddings.Should().ContainSingle();
        embeddings[0].Vector.Length.Should().Be(256);
    }
}
