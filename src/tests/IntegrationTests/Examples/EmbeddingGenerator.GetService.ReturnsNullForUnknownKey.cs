/*
order: 50
title: Embedding Generator Get Service Returns Null For Unknown Key
slug: embedding-generator-get-service-returns-null-for-unknown-key
*/

using Microsoft.Extensions.AI;

namespace Jina.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void EmbeddingGenerator_GetService_ReturnsNullForUnknownKey()
    {
        using var client = CreateTestClient();
        IEmbeddingGenerator<string, Embedding<float>> generator = client;

        var result = generator.GetService<EmbeddingGeneratorMetadata>(serviceKey: "unknown");

        result.Should().BeNull();
    }
}
