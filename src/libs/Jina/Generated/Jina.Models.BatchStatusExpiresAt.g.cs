
#nullable enable

namespace Jina
{
    /// <summary>
    /// ISO 8601 timestamp when output URL expires (created_at + 24h).
    /// </summary>
    public sealed partial class BatchStatusExpiresAt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}