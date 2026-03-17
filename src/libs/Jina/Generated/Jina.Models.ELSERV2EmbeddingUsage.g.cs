
#nullable enable

namespace Jina
{
    /// <summary>
    /// Token usage statistics for Elser v2 embedding requests.
    /// </summary>
    public sealed partial class ELSERV2EmbeddingUsage
    {
        /// <summary>
        /// Number of tokens in the input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// Number of tokens in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Total number of tokens processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ELSERV2EmbeddingUsage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// Number of tokens in the input.
        /// </param>
        /// <param name="outputTokens">
        /// Number of tokens in the output.
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens processed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ELSERV2EmbeddingUsage(
            int inputTokens,
            int outputTokens,
            int totalTokens)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ELSERV2EmbeddingUsage" /> class.
        /// </summary>
        public ELSERV2EmbeddingUsage()
        {
        }
    }
}