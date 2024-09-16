using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var text = await File.ReadAllTextAsync(path);

text = text
        .Replace("openapi: 3.1.0", "openapi: 3.0.1")
        .Replace("\"openapi\":\"3.1.0\"", "\"openapi\":\"3.0.1\"")
    ;

var openApiDocument = new OpenApiStringReader().Read(text, out var diagnostics);

openApiDocument.Components.Schemas["ImageDoc"]!.Properties["id"].Example = null;
openApiDocument.Components.Schemas["api_schemas__embedding__TextDoc"]!.Properties["id"].Example = null;
openApiDocument.Components.Schemas["api_schemas__rank__TextDoc"]!.Properties["id"].Example = null;

openApiDocument.SecurityRequirements = new List<OpenApiSecurityRequirement>
{
    new()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Id = "HTTPBearer",
                    Type = ReferenceType.SecurityScheme,
                }
            },
            new List<string>()
        }
    }
};
openApiDocument.Servers = new List<OpenApiServer>
{
    new()
    {
        Url = "https://api.jina.ai/"
    }
};

text = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(text, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, text);
return;