using AutoSDK.Helpers;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Readers;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

if (OpenApi31Support.IsOpenApi31(yamlOrJson))
{
    yamlOrJson = OpenApi31Support.ConvertToOpenApi30(yamlOrJson);
}

var openApiDocument = new OpenApiStringReader().Read(yamlOrJson, out var diagnostics);

// Use static examples for id properties from the OpenAPI spec because they change every time the spec is generated
foreach (var pair in openApiDocument.Components.Schemas)
{
    foreach (var (propertyName, property) in pair.Value.Properties)
    {
        if (propertyName == "id")
        {
            property.Example = new OpenApiString("50336949b5bd1f1ed97f3085d76258a1");
        }
    }
}

yamlOrJson = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(yamlOrJson, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, yamlOrJson);
return;
