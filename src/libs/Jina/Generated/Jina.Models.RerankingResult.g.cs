
#nullable enable

namespace Jina
{
    /// <summary>
    /// A single reranking result.
    /// </summary>
    public sealed partial class RerankingResult
    {
        /// <summary>
        /// Document content, if `return_documents=true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc, object>))]
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, object>? Document { get; set; }

        /// <summary>
        /// Document embedding, if `return_embeddings=true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        public global::System.Collections.Generic.IList<double>? Embedding { get; set; }

        /// <summary>
        /// Position of this document in the original input list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Relevance score. Higher is more relevant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevance_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RelevanceScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankingResult" /> class.
        /// </summary>
        /// <param name="document">
        /// Document content, if `return_documents=true`.
        /// </param>
        /// <param name="embedding">
        /// Document embedding, if `return_embeddings=true`.
        /// </param>
        /// <param name="index">
        /// Position of this document in the original input list.
        /// </param>
        /// <param name="relevanceScore">
        /// Relevance score. Higher is more relevant.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankingResult(
            int index,
            double relevanceScore,
            global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, object>? document,
            global::System.Collections.Generic.IList<double>? embedding)
        {
            this.Index = index;
            this.RelevanceScore = relevanceScore;
            this.Document = document;
            this.Embedding = embedding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankingResult" /> class.
        /// </summary>
        public RerankingResult()
        {
        }
    }
}