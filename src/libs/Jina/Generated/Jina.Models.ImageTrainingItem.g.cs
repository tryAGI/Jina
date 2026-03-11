
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageTrainingItem
    {
        /// <summary>
        /// Input image URL or base64 for training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// Label for the input image.
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
        /// Initializes a new instance of the <see cref="ImageTrainingItem" /> class.
        /// </summary>
        /// <param name="image">
        /// Input image URL or base64 for training.
        /// </param>
        /// <param name="label">
        /// Label for the input image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageTrainingItem(
            string image,
            string label)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageTrainingItem" /> class.
        /// </summary>
        public ImageTrainingItem()
        {
        }
    }
}