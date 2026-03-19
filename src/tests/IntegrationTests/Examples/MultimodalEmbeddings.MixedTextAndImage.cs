/*
order: 80
title: Multimodal Embeddings Mixed Text And Image
slug: multimodal-embeddings-mixed-text-and-image
*/

using Microsoft.Extensions.AI;

namespace Jina.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task MultimodalEmbeddings_MixedTextAndImage()
    {
        using var client = GetAuthenticatedClient();

        var items = new AnyOf<string, TextDoc, ImageDoc>[]
        {
            "A beautiful sunset over the ocean",
            new ImageDoc { Image = "https://i.ibb.co/nQNGqL0/beach1.jpg" },
        };

        var embeddings = await client.GenerateMixedEmbeddingsAsync(
            items,
            new EmbeddingGenerationOptions
            {
                Dimensions = 256,
            });

        embeddings.Should().HaveCount(2);
        foreach (var embedding in embeddings)
        {
            embedding.Vector.Length.Should().Be(256);
        }
    }
}
