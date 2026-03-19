# Embedding Generator Custom Dimensions



This example assumes `using Jina;` is in scope and `apiKey` contains your Jina API key.

```csharp
using var client = new JinaClient(apiKey);

IEmbeddingGenerator<string, Embedding<float>> generator = client;
var embeddings = await generator.GenerateAsync(
    ["Hello, world!"],
    new EmbeddingGenerationOptions
    {
        ModelId = "jina-embeddings-v3",
        Dimensions = 256,
    });
```