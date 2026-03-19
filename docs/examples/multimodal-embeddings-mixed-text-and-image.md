# Multimodal Embeddings Mixed Text And Image



This example assumes `using Jina;` is in scope and `apiKey` contains your Jina API key.

```csharp
using var client = new JinaClient(apiKey);

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

foreach (var embedding in embeddings)
{
}
```