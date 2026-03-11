
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
        public string Model { get; set; } = default!;

        /// <summary>
        /// Object type, always `list`.<br/>
        /// Default Value: list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Token usage statistics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Jina.BaseUsage Usage { get; set; } = default!;

        /// <summary>
        /// Ranked documents, sorted by relevance score descending.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Jina.RerankingResult> Results { get; set; } = default!;

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
        /// <param name="object">
        /// Object type, always `list`.<br/>
        /// Default Value: list
        /// </param>
        /// <param name="usage">
        /// Token usage statistics.
        /// </param>
        /// <param name="results">
        /// Ranked documents, sorted by relevance score descending.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankingResponse(
            string model,
            global::Jina.BaseUsage usage,
            global::System.Collections.Generic.IList<global::Jina.RerankingResult> results,
            string? @object)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankingResponse" /> class.
        /// </summary>
        public RerankingResponse()
        {
        }
    }
}