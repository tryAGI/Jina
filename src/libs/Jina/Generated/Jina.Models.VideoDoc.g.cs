
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoDoc
    {
        /// <summary>
        /// Video as a URL or base64-encoded string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Video { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoDoc" /> class.
        /// </summary>
        /// <param name="video">
        /// Video as a URL or base64-encoded string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoDoc(
            string video)
        {
            this.Video = video ?? throw new global::System.ArgumentNullException(nameof(video));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoDoc" /> class.
        /// </summary>
        public VideoDoc()
        {
        }
    }
}