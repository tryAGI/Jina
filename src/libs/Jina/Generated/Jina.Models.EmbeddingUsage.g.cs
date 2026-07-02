
#nullable enable

namespace Jina
{
    /// <summary>
    /// Token usage statistics for embedding requests.<br/>
    /// `prompt_tokens` counts text input tokens (including the task prefix and<br/>
    /// any structural/special framing). For text-only models — and any response<br/>
    /// that doesn't populate a per-modality breakdown — it equals `total_tokens`.<br/>
    /// For multimodal v5-omni responses, `total_tokens` is the aggregate across<br/>
    /// all modalities and the per-modality fields (`image_tokens` /<br/>
    /// `audio_tokens` / `video_tokens`) are sub-counts, so the invariant holds<br/>
    /// exactly (absent per-modality fields count as 0):<br/>
    ///     total_tokens == prompt_tokens + image_tokens + audio_tokens + video_tokens<br/>
    /// PDF pages are rendered to images and counted in `image_tokens`.<br/>
    /// All MM fields are Optional so text-only responses don't have to populate<br/>
    /// them, and serializers should drop unset fields (`exclude_none=True`).
    /// </summary>
    public sealed partial class EmbeddingUsage
    {
        /// <summary>
        /// Number of tokens from audio inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_tokens")]
        public int? AudioTokens { get; set; }

        /// <summary>
        /// Number of tokens from image inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_tokens")]
        public int? ImageTokens { get; set; }

        /// <summary>
        /// Number of text input tokens. For multimodal responses the per-modality fields below account for non-text tokens; for text-only responses this equals `total_tokens`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// Total number of tokens processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Number of tokens from video inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_tokens")]
        public int? VideoTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingUsage" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// Number of text input tokens. For multimodal responses the per-modality fields below account for non-text tokens; for text-only responses this equals `total_tokens`.
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens processed.
        /// </param>
        /// <param name="audioTokens">
        /// Number of tokens from audio inputs.
        /// </param>
        /// <param name="imageTokens">
        /// Number of tokens from image inputs.
        /// </param>
        /// <param name="videoTokens">
        /// Number of tokens from video inputs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingUsage(
            int promptTokens,
            int totalTokens,
            int? audioTokens,
            int? imageTokens,
            int? videoTokens)
        {
            this.AudioTokens = audioTokens;
            this.ImageTokens = imageTokens;
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
            this.VideoTokens = videoTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingUsage" /> class.
        /// </summary>
        public EmbeddingUsage()
        {
        }

    }
}