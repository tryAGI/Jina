
#nullable enable

namespace Jina
{
    /// <summary>
    /// If true, concatenates all text inputs and processes as one sequence before splitting. Only works with text.
    /// </summary>
    public sealed partial class EmbeddingsV4RequestLateChunking
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}