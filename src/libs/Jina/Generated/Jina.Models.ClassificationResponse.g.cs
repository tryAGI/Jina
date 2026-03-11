
#nullable enable

namespace Jina
{
    /// <summary>
    /// Response containing classification results.
    /// </summary>
    public sealed partial class ClassificationResponse
    {
        /// <summary>
        /// Classification results, one per input item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Jina.ClassificationPrediction> Data { get; set; } = default!;

        /// <summary>
        /// Token usage statistics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Jina.BaseUsage Usage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Classification results, one per input item.
        /// </param>
        /// <param name="usage">
        /// Token usage statistics.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassificationResponse(
            global::System.Collections.Generic.IList<global::Jina.ClassificationPrediction> data,
            global::Jina.BaseUsage usage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationResponse" /> class.
        /// </summary>
        public ClassificationResponse()
        {
        }
    }
}