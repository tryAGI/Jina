
#nullable enable

namespace Jina
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponseFormatJSONSchema
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.JSONSchemaSpec JsonSchema { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"json_schema"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "json_schema";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatJSONSchema" /> class.
        /// </summary>
        /// <param name="jsonSchema"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFormatJSONSchema(
            global::Jina.JSONSchemaSpec jsonSchema,
            string type = "json_schema")
        {
            this.JsonSchema = jsonSchema ?? throw new global::System.ArgumentNullException(nameof(jsonSchema));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatJSONSchema" /> class.
        /// </summary>
        public ResponseFormatJSONSchema()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ResponseFormatJSONSchema"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ResponseFormatJSONSchema FromJsonSchema(global::Jina.JSONSchemaSpec jsonSchema)
        {
            return new ResponseFormatJSONSchema
            {
                JsonSchema = jsonSchema,
            };
        }

    }
}