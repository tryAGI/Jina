# Create Embedding



This example assumes `using Jina;` is in scope and `apiKey` contains your Jina API key.

```csharp
using var client = new JinaClient(apiKey);

var response = await client.SearchFoundationModels.EmbeddingsAsync(
    new EmbeddingsV2Request
    {
        Model = EmbeddingsV2RequestModel.JinaEmbeddingsV2BaseEn,
        Input = "Hello, world!",
    });

var embedding = response.Data.Value1![0].Embedding.Value2;
Console.WriteLine($"[{string.Join(", ", embedding ?? [])}]");
```