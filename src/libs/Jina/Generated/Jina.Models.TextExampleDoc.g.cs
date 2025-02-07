
#nullable enable

namespace Jina
{
    /// <summary>
    /// Document containing a text field and a label
    /// </summary>
    public sealed partial class TextExampleDoc
    {
        /// <summary>
        /// The ID of the BaseDoc. This is useful for indexing in vector stores. If not set by user, it will automatically be assigned a random value<br/>
        /// Example: 50336949b5bd1f1ed97f3085d76258a1
        /// </summary>
        /// <example>50336949b5bd1f1ed97f3085d76258a1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The example text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The label of the text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextExampleDoc" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the BaseDoc. This is useful for indexing in vector stores. If not set by user, it will automatically be assigned a random value<br/>
        /// Example: 50336949b5bd1f1ed97f3085d76258a1
        /// </param>
        /// <param name="text">
        /// The example text
        /// </param>
        /// <param name="label">
        /// The label of the text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextExampleDoc(
            string text,
            string label,
            string? id)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextExampleDoc" /> class.
        /// </summary>
        public TextExampleDoc()
        {
        }
    }
}