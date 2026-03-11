
#nullable enable

namespace Jina
{
    /// <summary>
    /// Example: {"classifier_id":"00000000-0000-0000-0000-000000000000","num_samples":6,"usage":{"total_tokens":1830}}
    /// </summary>
    public sealed partial class TrainingResponse
    {
        /// <summary>
        /// ID of the classifier that was trained or updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClassifierId { get; set; }

        /// <summary>
        /// Number of training samples processed in this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_samples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumSamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Jina.BaseUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingResponse" /> class.
        /// </summary>
        /// <param name="classifierId">
        /// ID of the classifier that was trained or updated.
        /// </param>
        /// <param name="numSamples">
        /// Number of training samples processed in this request.
        /// </param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingResponse(
            string classifierId,
            int numSamples,
            global::Jina.BaseUsage? usage)
        {
            this.ClassifierId = classifierId ?? throw new global::System.ArgumentNullException(nameof(classifierId));
            this.NumSamples = numSamples;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingResponse" /> class.
        /// </summary>
        public TrainingResponse()
        {
        }
    }
}