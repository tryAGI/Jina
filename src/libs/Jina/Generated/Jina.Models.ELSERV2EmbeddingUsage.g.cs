
#nullable enable

namespace Jina
{
    /// <summary>
    /// Token usage statistics for Elser v2 embedding requests.
    /// </summary>
    public sealed partial class ELSERV2EmbeddingUsage
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
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int InputTokens { get; set; } = default!;

        /// <summary>
        /// Number of tokens in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int OutputTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ELSERV2EmbeddingUsage" /> class.
        /// </summary>
        /// <param name="totalTokens">
        /// Total number of tokens processed.
        /// </param>
        /// <param name="inputTokens">
        /// Number of tokens in the input.
        /// </param>
        /// <param name="outputTokens">
        /// Number of tokens in the output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ELSERV2EmbeddingUsage(
            int totalTokens,
            int inputTokens,
            int outputTokens)
        {
            this.TotalTokens = totalTokens;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ELSERV2EmbeddingUsage" /> class.
        /// </summary>
        public ELSERV2EmbeddingUsage()
        {
        }
    }
}