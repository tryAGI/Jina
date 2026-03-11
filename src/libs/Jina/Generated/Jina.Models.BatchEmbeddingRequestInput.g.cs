
#nullable enable

namespace Jina
{
    /// <summary>
    /// Inline JSONL lines for small batches. Either input_url or input must be provided.
    /// </summary>
    public sealed partial class BatchEmbeddingRequestInput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}