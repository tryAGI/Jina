
#nullable enable

namespace Jina
{
    /// <summary>
    /// Set to `retrieval.query` to optimize for search queries. Leave unset for documents.
    /// </summary>
    public sealed partial class ClipV2RequestTask
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}