
#nullable enable

namespace Jina
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageContentPart
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.ImageURL ImageUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"image_url"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "image_url";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageContentPart" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageContentPart(
            global::Jina.ImageURL imageUrl,
            string type = "image_url")
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageContentPart" /> class.
        /// </summary>
        public ImageContentPart()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ImageContentPart"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ImageContentPart FromImageUrl(global::Jina.ImageURL imageUrl)
        {
            return new ImageContentPart
            {
                ImageUrl = imageUrl,
            };
        }

    }
}