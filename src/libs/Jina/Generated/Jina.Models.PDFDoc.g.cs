
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PDFDoc
    {
        /// <summary>
        /// PDF as a URL or base64-encoded string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pdf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PDFDoc" /> class.
        /// </summary>
        /// <param name="pdf">
        /// PDF as a URL or base64-encoded string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PDFDoc(
            string pdf)
        {
            this.Pdf = pdf ?? throw new global::System.ArgumentNullException(nameof(pdf));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PDFDoc" /> class.
        /// </summary>
        public PDFDoc()
        {
        }
    }
}