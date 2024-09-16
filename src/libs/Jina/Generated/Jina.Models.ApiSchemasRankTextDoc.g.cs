
#nullable enable

namespace Jina
{
    /// <summary>
    /// Document containing a text field
    /// </summary>
    public sealed partial class ApiSchemasRankTextDoc
    {
        /// <summary>
        /// The ID of the BaseDoc. This is useful for indexing in vector stores. If not set by user, it will automatically be assigned a random value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}