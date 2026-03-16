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