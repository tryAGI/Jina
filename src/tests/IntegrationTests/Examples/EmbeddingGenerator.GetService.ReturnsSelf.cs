/*
order: 60
title: Embedding Generator Get Service Returns Self
slug: embedding-generator-get-service-returns-self
*/

using Microsoft.Extensions.AI;

namespace Jina.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void EmbeddingGenerator_GetService_ReturnsSelf()
    {
        using var client = CreateTestClient();
        IEmbeddingGenerator<string, Embedding<float>> generator = client;

        var self = generator.GetService<JinaClient>();

        self.Should().BeSameAs(client);
    }
}
