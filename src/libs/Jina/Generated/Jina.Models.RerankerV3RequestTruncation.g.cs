
#nullable enable

namespace Jina
{
    /// <summary>
    /// If true, truncates documents exceeding the model's max token limit.
    /// </summary>
    public sealed partial class RerankerV3RequestTruncation
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}