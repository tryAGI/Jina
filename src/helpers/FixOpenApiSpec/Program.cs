using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

var openApiDocument = yamlOrJson.GetOpenApiDocument(Settings.Default);

// Use static examples for id properties from the OpenAPI spec because they change every time the spec is generated
foreach (var pair in openApiDocument.Components!.Schemas!)
{
    foreach (var (propertyName, property) in ((OpenApiSchema)pair.Value).Properties!)
    {
        if (propertyName == "id" && property is OpenApiSchema idSchema)
        {
            idSchema.Default = JsonValue.Create("50336949b5bd1f1ed97f3085d76258a1");
        }
    }
}

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);

await File.WriteAllTextAsync(path, yamlOrJson);
