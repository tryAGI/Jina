
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextDoc
    {
        /// <summary>
        /// Text content to process.
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
        /// Initializes a new instance of the <see cref="TextDoc" /> class.
        /// </summary>
        /// <param name="text">
        /// Text content to process.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextDoc(
            string text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextDoc" /> class.
        /// </summary>
        public TextDoc()
        {
        }
    }
}