
#nullable enable

namespace Jina
{
    /// <summary>
    /// Statistics for a batch job.
    /// </summary>
    public sealed partial class BatchStats
    {
        /// <summary>
        /// Total number of input lines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Number of successfully processed lines.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        public int? Completed { get; set; }

        /// <summary>
        /// Number of failed lines.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        public int? Failed { get; set; }

        /// <summary>
        /// Total tokens consumed across all processed lines.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchStats" /> class.
        /// </summary>
        /// <param name="total">
        /// Total number of input lines.
        /// </param>
        /// <param name="completed">
        /// Number of successfully processed lines.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="failed">
        /// Number of failed lines.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="totalTokens">
        /// Total tokens consumed across all processed lines.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchStats(
            int total,
            int? completed,
            int? failed,
            int? totalTokens)
        {
            this.Total = total;
            this.Completed = completed;
            this.Failed = failed;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchStats" /> class.
        /// </summary>
        public BatchStats()
        {
        }
    }
}