
#nullable enable

namespace Jina
{
    /// <summary>
    /// Role of the input: `query` for search queries, `document` for passages.<br/>
    /// Default Value: document
    /// </summary>
    public sealed partial class ColbertV1RequestInputType
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}