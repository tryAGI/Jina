
#nullable enable

namespace Jina
{
    /// <summary>
    /// URL to input JSONL file (GCS, S3, or HTTP). Either input_url or input must be provided.
    /// </summary>
    public sealed partial class BatchEmbeddingRequestInputUrl
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}