/*
order: 40
title: Embedding Generator Get Service Returns Metadata
slug: embedding-generator-get-service-returns-metadata
*/

using Microsoft.Extensions.AI;

namespace Jina.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void EmbeddingGenerator_GetService_ReturnsMetadata()
    {
        using var client = CreateTestClient();
        IEmbeddingGenerator<string, Embedding<float>> generator = client;

        var metadata = generator.GetService<EmbeddingGeneratorMetadata>();

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be(nameof(JinaClient));
    }
}
