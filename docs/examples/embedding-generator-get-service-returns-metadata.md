# Embedding Generator Get Service Returns Metadata



This example assumes `using Jina;` is in scope and `apiKey` contains your Jina API key.

```csharp
using var client = CreateTestClient();
IEmbeddingGenerator<string, Embedding<float>> generator = client;

var metadata = generator.GetService<EmbeddingGeneratorMetadata>();
```