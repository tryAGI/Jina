
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageDoc
    {
        /// <summary>
        /// Image as a URL or base64-encoded string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDoc" /> class.
        /// </summary>
        /// <param name="image">
        /// Image as a URL or base64-encoded string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageDoc(
            string image)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDoc" /> class.
        /// </summary>
        public ImageDoc()
        {
        }
    }
}