
#nullable enable

namespace Jina
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StreamOptions
    {
        /// <summary>
        /// Report token usage in the stream. When set, every chunk carries `usage: null` and a final chunk carries the totals. When unset, no chunk mentions usage and the final chunk is not sent at all.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_usage")]
        public bool? IncludeUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamOptions" /> class.
        /// </summary>
        /// <param name="includeUsage">
        /// Report token usage in the stream. When set, every chunk carries `usage: null` and a final chunk carries the totals. When unset, no chunk mentions usage and the final chunk is not sent at all.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamOptions(
            bool? includeUsage)
        {
            this.IncludeUsage = includeUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamOptions" /> class.
        /// </summary>
        public StreamOptions()
        {
        }

    }
}