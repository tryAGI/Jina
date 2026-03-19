# Multimodal Embeddings Single Image



This example assumes `using Jina;` is in scope and `apiKey` contains your Jina API key.

```csharp
using var client = new JinaClient(apiKey);

var embeddings = await client.GenerateImageEmbeddingsAsync(
    ["https://i.ibb.co/nQNGqL0/beach1.jpg"],
    new EmbeddingGenerationOptions
    {
        Dimensions = 256,
    });
```