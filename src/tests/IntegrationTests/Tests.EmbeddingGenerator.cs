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

    [TestMethod]
    public void EmbeddingGenerator_GetService_ReturnsMetadata()
    {
        using var client = CreateTestClient();
        IEmbeddingGenerator<string, Embedding<float>> generator = client;

        var metadata = generator.GetService<EmbeddingGeneratorMetadata>();

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be(nameof(JinaClient));
    }

    [TestMethod]
    public void EmbeddingGenerator_GetService_ReturnsSelf()
    {
        using var client = CreateTestClient();
        IEmbeddingGenerator<string, Embedding<float>> generator = client;

        var self = generator.GetService<JinaClient>();

        self.Should().BeSameAs(client);
    }

    [TestMethod]
    public void EmbeddingGenerator_GetService_ReturnsNullForUnknownKey()
    {
        using var client = CreateTestClient();
        IEmbeddingGenerator<string, Embedding<float>> generator = client;

        var result = generator.GetService<EmbeddingGeneratorMetadata>(serviceKey: "unknown");

        result.Should().BeNull();
    }
}
