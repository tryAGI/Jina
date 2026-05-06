
#nullable enable

namespace Jina
{
    /// <summary>
    /// Token usage statistics for embedding requests.<br/>
    /// For embeddings (no completion), `prompt_tokens == total_tokens` always —<br/>
    /// matching jina-clip-v2 and the OpenAI completion-shape convention. For<br/>
    /// multimodal v5 responses, per-modality fields (`image_tokens` /<br/>
    /// `audio_tokens` / `video_tokens`) are descriptive sub-counts of<br/>
    /// `total_tokens`: their sum is `&lt;= total_tokens`, with the residue being<br/>
    /// text / chat-template / structural tokens that aren't surfaced in their<br/>
    /// own bucket.<br/>
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
        /// Tokens in the input. Equal to `total_tokens` for embeddings (no completion). Per-modality fields below are sub-counts.
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
        /// Tokens in the input. Equal to `total_tokens` for embeddings (no completion). Per-modality fields below are sub-counts.
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