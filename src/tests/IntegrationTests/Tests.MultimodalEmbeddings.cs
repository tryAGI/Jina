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
