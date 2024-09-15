namespace Jina.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateEmbedding()
    {
        using var api = GetAuthenticatedApi();

        var response = await api.Embeddings.CreateEmbeddingAsync(new TextEmbeddingInput
        {
            Model = "jina-clip-v1",
            Input = new List<ApiSchemasEmbeddingTextDoc>
            {
                new()
                {
                    Id = "1",
                    Text = "Hello, world!",
                }
            }
        });
        
        Console.WriteLine($"[{string.Join(", ", response.Data[0].Embedding ?? [])}]");
        
        response.Data[0].Should().NotBeNull();
    }
}
