
#nullable enable

namespace Jina
{
    /// <summary>
    /// Response containing ranked documents.
    /// </summary>
    public sealed partial class RerankingResponse
    {
        /// <summary>
        /// The model used for reranking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Object type, always `list`.<br/>
        /// Default Value: list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Ranked documents, sorted by relevance score descending.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Jina.RerankingResult> Results { get; set; }

        /// <summary>
        /// Token usage statistics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.BaseUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankingResponse" /> class.
        /// </summary>
        /// <param name="model">
        /// The model used for reranking.
        /// </param>
        /// <param name="results">
        /// Ranked documents, sorted by relevance score descending.
        /// </param>
        /// <param name="usage">
        /// Token usage statistics.
        /// </param>
        /// <param name="object">
        /// Object type, always `list`.<br/>
        /// Default Value: list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankingResponse(
            string model,
            global::System.Collections.Generic.IList<global::Jina.RerankingResult> results,
            global::Jina.BaseUsage usage,
            string? @object)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Object = @object;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankingResponse" /> class.
        /// </summary>
        public RerankingResponse()
        {
        }
    }
}