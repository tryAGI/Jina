
#nullable enable

namespace Jina
{
    /// <summary>
    /// Task optimization: retrieval, text-matching, clustering, or classification.<br/>
    /// Default Value: text-matching
    /// </summary>
    public sealed partial class BatchEmbeddingRequestTask
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}