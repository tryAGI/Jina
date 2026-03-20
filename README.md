# Jina

[![Nuget package](https://img.shields.io/nuget/vpre/Jina)](https://www.nuget.org/packages/Jina/)
[![dotnet](https://github.com/tryAGI/Jina/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Jina/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Jina)](https://github.com/tryAGI/Jina/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Jina OpenAPI specification](https://api.jina.ai/openapi.json) using [AutoSDK](https://github.com/tryAGI/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- Microsoft.Extensions.AI `IEmbeddingGenerator` support

### Usage
```csharp
using Jina;

using var api = new JinaApi(apiKey);

var response = await api.Embeddings.CreateEmbeddingAsync(new TextEmbeddingInput
{
    Model = "jina-clip-v1",
    Input = new List<ApiSchemasEmbeddingTextDoc>
    {
        new()
        {
            Text = "Hello, world!",
        }
    }
});

Console.WriteLine($"[{string.Join(", ", response.Data[0].Embedding ?? [])}]");
```

### Microsoft.Extensions.AI

The SDK implements [`IEmbeddingGenerator`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.iembeddinggenerator-2):
```csharp
using Jina;
using Microsoft.Extensions.AI;

IEmbeddingGenerator<string, Embedding<float>> generator = new JinaApi(apiKey);

var embeddings = await generator.GenerateAsync(
    ["Hello, world!"],
    new EmbeddingGenerationOptions { ModelId = "jina-embeddings-v3" });

Console.WriteLine($"Embedding dimension: {embeddings[0].Vector.Length}");
```

<!-- EXAMPLES:START -->
### Create Embedding
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

### Embedding Generator Batch Texts
```csharp
using var client = new JinaClient(apiKey);

IEmbeddingGenerator<string, Embedding<float>> generator = client;
var embeddings = await generator.GenerateAsync(
    ["Hello", "World", "Test"],
    new EmbeddingGenerationOptions
    {
        ModelId = "jina-embeddings-v3",
    });

foreach (var embedding in embeddings)
{
}
```

### Embedding Generator Custom Dimensions
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

### Embedding Generator Get Service Returns Metadata
```csharp
using var client = CreateTestClient();
IEmbeddingGenerator<string, Embedding<float>> generator = client;

var metadata = generator.GetService<EmbeddingGeneratorMetadata>();
```

### Embedding Generator Get Service Returns Null For Unknown Key
```csharp
using var client = CreateTestClient();
IEmbeddingGenerator<string, Embedding<float>> generator = client;

var result = generator.GetService<EmbeddingGeneratorMetadata>(serviceKey: "unknown");
```

### Embedding Generator Get Service Returns Self
```csharp
using var client = CreateTestClient();
IEmbeddingGenerator<string, Embedding<float>> generator = client;

var self = generator.GetService<JinaClient>();
```

### Embedding Generator Single Text
```csharp
using var client = new JinaClient(apiKey);

IEmbeddingGenerator<string, Embedding<float>> generator = client;
var embeddings = await generator.GenerateAsync(
    ["Hello, world!"],
    new EmbeddingGenerationOptions
    {
        ModelId = "jina-embeddings-v3",
    });
```

### Multimodal Embeddings Mixed Text And Image
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

### Multimodal Embeddings Single Image
```csharp
using var client = new JinaClient(apiKey);

var embeddings = await client.GenerateImageEmbeddingsAsync(
    ["https://i.ibb.co/nQNGqL0/beach1.jpg"],
    new EmbeddingGenerationOptions
    {
        Dimensions = 256,
    });
```

### Rerank
```csharp
using var client = new JinaClient(apiKey);

        RerankingResponse output = await client.SearchFoundationModels.RerankAsync(
            new TextRerankerRequest
            {
                Model = TextRerankerRequestModel.JinaRerankerV2BaseMultilingual,
                Query = "Organic skincare products for sensitive skin",
                TopN = 3,
                Documents =
                [
                    "Organic skincare for sensitive skin with aloe vera and chamomile.",
                    "New makeup trends focus on bold colors and innovative techniques.",
                    "Bio-Hautpflege für empfindliche Haut mit Aloe Vera und Kamille.",
                    "Neue Make-up-Trends setzen auf kräftige Farben und innovative Techniken.",
                    "Cuidado de la piel orgánico para piel sensible con aloe vera y manzanilla.",
                    "Las nuevas tendencias de maquillaje se centran en colores vivos y técnicas innovadoras.",
                ],
            });

        foreach (RerankingResult result in output.Results)
        {
            Console.WriteLine($@"
Index: {result.Index}
Document: {result.Document?.Value1 ?? result.Document?.Value2?.Text}
RelevanceScore: {result.RelevanceScore}");
        }
```
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Jina/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Jina/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
