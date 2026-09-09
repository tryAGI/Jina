
#nullable enable

namespace Jina
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageURL
    {
        /// <summary>
        /// An `http(s)` URL or a `data:image/...;base64,` URI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageURL" /> class.
        /// </summary>
        /// <param name="url">
        /// An `http(s)` URL or a `data:image/...;base64,` URI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageURL(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageURL" /> class.
        /// </summary>
        public ImageURL()
        {
        }

    }
}