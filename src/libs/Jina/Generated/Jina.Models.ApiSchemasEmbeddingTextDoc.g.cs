
#nullable enable

namespace Jina
{
    /// <summary>
    /// Document containing a text field
    /// </summary>
    public sealed partial class ApiSchemasEmbeddingTextDoc
    {
        /// <summary>
        /// The ID of the BaseDoc. This is useful for indexing in vector stores. If not set by user, it will automatically be assigned a random value<br/>
        /// Example: 50336949b5bd1f1ed97f3085d76258a1
        /// </summary>
        /// <example>50336949b5bd1f1ed97f3085d76258a1</example>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiSchemasEmbeddingTextDoc" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the BaseDoc. This is useful for indexing in vector stores. If not set by user, it will automatically be assigned a random value<br/>
        /// Example: 50336949b5bd1f1ed97f3085d76258a1
        /// </param>
        /// <param name="text"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiSchemasEmbeddingTextDoc(
            string text,
            string? id)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiSchemasEmbeddingTextDoc" /> class.
        /// </summary>
        public ApiSchemasEmbeddingTextDoc()
        {
        }
    }
}