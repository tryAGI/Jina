
#nullable enable

namespace Jina
{
    /// <summary>
    /// If true, concatenates all inputs and processes as one sequence before splitting. Useful for context across chunks.
    /// </summary>
    public sealed partial class EmbeddingsV3RequestLateChunking
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}