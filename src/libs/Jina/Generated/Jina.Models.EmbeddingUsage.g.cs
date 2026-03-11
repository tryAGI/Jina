
#nullable enable

namespace Jina
{
    /// <summary>
    /// Token usage statistics for embedding requests.
    /// </summary>
    public sealed partial class EmbeddingUsage
    {
        /// <summary>
        /// Total number of tokens processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int TotalTokens { get; set; } = default!;

        /// <summary>
        /// Number of tokens in the input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int PromptTokens { get; set; } = default!;

        /// <summary>
        /// Number of tokens from image inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_tokens")]
        public int? ImageTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingUsage" /> class.
        /// </summary>
        /// <param name="totalTokens">
        /// Total number of tokens processed.
        /// </param>
        /// <param name="promptTokens">
        /// Number of tokens in the input.
        /// </param>
        /// <param name="imageTokens">
        /// Number of tokens from image inputs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingUsage(
            int totalTokens,
            int promptTokens,
            int? imageTokens)
        {
            this.TotalTokens = totalTokens;
            this.PromptTokens = promptTokens;
            this.ImageTokens = imageTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingUsage" /> class.
        /// </summary>
        public EmbeddingUsage()
        {
        }
    }
}