namespace Jina.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateEmbedding()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.SearchFoundationModels.EmbeddingsAsync(
            new EmbeddingsV2Request
            {
                Model = EmbeddingsV2RequestModel.JinaEmbeddingsV2BaseEn,
                Input = "Hello, world!",
            });

        response.Data.Value1.Should().NotBeNullOrEmpty();

        var embedding = response.Data.Value1![0].Embedding.Value2;
        Console.WriteLine($"[{string.Join(", ", embedding ?? [])}]");

        embedding.Should().NotBeNullOrEmpty();
    }
}
