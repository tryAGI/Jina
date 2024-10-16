using AutoSDK.Helpers;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

if (OpenApi31Support.IsOpenApi31(yamlOrJson))
{
    yamlOrJson = OpenApi31Support.ConvertToOpenApi30(yamlOrJson);
}

var openApiDocument = new OpenApiStringReader().Read(yamlOrJson, out var diagnostics);

openApiDocument.Components.Schemas["ModelEmbeddingOutput"]!.Properties["data"].Items = new OpenApiSchema
{
    Type = "object",
    Properties = new Dictionary<string, OpenApiSchema>
    {
        ["index"] = new()
        {
            Type = "integer",
        },
        ["embedding"] = new()
        {
            Type = "array",
            Items = new OpenApiSchema
            {
                Type = "number",
                Format = "float",
            }
        },
        ["object"] = new()
        {
            Type = "string",
        }
    }
};

openApiDocument.Components.Schemas["RankingOutput"]!.Properties["results"].Items = new OpenApiSchema
{
    Type = "object",
    Properties = new Dictionary<string, OpenApiSchema>
    {
        ["index"] = new()
        {
            Type = "integer",
            Format = "int64",
        },
        ["relevance_score"] = new()
        {
            Type = "number",
            Format = "double",
        },
        ["document"] = new()
        {
            Type = "object",
            Properties = new Dictionary<string, OpenApiSchema>
            {
                ["text"] = new()
                {
                    Type = "string",
                }
            }
        }
    }
};
    
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