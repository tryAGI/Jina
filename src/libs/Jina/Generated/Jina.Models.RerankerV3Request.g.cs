
#nullable enable

namespace Jina
{
    /// <summary>
    /// Reranker v3 listwise model for high-quality multilingual retrieval.<br/>
    /// Example: {"documents":["Climate Change and Renewable Energy: A Global Perspective. Rising temperatures and extreme weather events are accelerating the transition to solar and wind power worldwide.","Le changement climatique et l\u0027\u00E9nergie renouvelable : une perspective europ\u00E9enne. L\u0027Union europ\u00E9enne investit massivement dans les technologies vertes pour atteindre la neutralit\u00E9 carbone d\u0027ici 2050.","Klimawandel und erneuerbare Energien: Deutsche Energiewende. Deutschland f\u00FChrt die Transformation des Energiesektors durch innovative Technologien und politische Ma\u00DFnahmen an.","\u6C14\u5019\u53D8\u5316\u5BF9\u53EF\u518D\u751F\u80FD\u6E90\u7684\u5F71\u54CD\uFF1A\u4E2D\u56FD\u7684\u7EFF\u8272\u53D1\u5C55\u6218\u7565\u3002\u4E2D\u56FD\u6B63\u5728\u5927\u529B\u63A8\u8FDB\u592A\u9633\u80FD\u548C\u98CE\u80FD\u9879\u76EE\uFF0C\u4EE5\u5B9E\u73B0\u78B3\u4E2D\u548C\u76EE\u6807\u3002","Artificial Intelligence in Healthcare: Revolutionizing Medical Diagnosis. AI-powered systems are improving accuracy in disease detection and treatment recommendations.","Blockchain Technology: Transforming Financial Services. Decentralized finance applications are reshaping traditional banking and payment systems."],"model":"jina-reranker-v3","query":"Climate change impact on renewable energy adoption","return_documents":false,"return_embeddings":false,"top_n":4}
    /// </summary>
    public sealed partial class RerankerV3Request
    {
        /// <summary>
        /// Documents to rank: strings or `TextDoc` objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>> Documents { get; set; }

        /// <summary>
        /// Maximum tokens per document. Range: 1-8192. Default: 2048.<br/>
        /// Default Value: 2048
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_doc_length")]
        public int? MaxDocLength { get; set; }

        /// <summary>
        /// The reranking model to use.
        /// </summary>
        /// <default>"jina-reranker-v3"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "jina-reranker-v3";

        /// <summary>
        /// The search query to rank documents against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// If true (default), includes document content in each result.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_documents")]
        public bool? ReturnDocuments { get; set; }

        /// <summary>
        /// If true, returns the document embedding alongside the relevance score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_embeddings")]
        public bool? ReturnEmbeddings { get; set; }

        /// <summary>
        /// Number of top results to return. If not set, returns all documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_n")]
        public int? TopN { get; set; }

        /// <summary>
        /// If true, truncates documents exceeding the model's max token limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        public bool? Truncation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankerV3Request" /> class.
        /// </summary>
        /// <param name="documents">
        /// Documents to rank: strings or `TextDoc` objects.
        /// </param>
        /// <param name="query">
        /// The search query to rank documents against.
        /// </param>
        /// <param name="maxDocLength">
        /// Maximum tokens per document. Range: 1-8192. Default: 2048.<br/>
        /// Default Value: 2048
        /// </param>
        /// <param name="returnDocuments">
        /// If true (default), includes document content in each result.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="returnEmbeddings">
        /// If true, returns the document embedding alongside the relevance score.
        /// </param>
        /// <param name="topN">
        /// Number of top results to return. If not set, returns all documents.
        /// </param>
        /// <param name="truncation">
        /// If true, truncates documents exceeding the model's max token limit.
        /// </param>
        /// <param name="model">
        /// The reranking model to use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankerV3Request(
            global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>> documents,
            string query,
            int? maxDocLength,
            bool? returnDocuments,
            bool? returnEmbeddings,
            int? topN,
            bool? truncation,
            string model = "jina-reranker-v3")
        {
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.MaxDocLength = maxDocLength;
            this.Model = model;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.ReturnDocuments = returnDocuments;
            this.ReturnEmbeddings = returnEmbeddings;
            this.TopN = topN;
            this.Truncation = truncation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankerV3Request" /> class.
        /// </summary>
        public RerankerV3Request()
        {
        }
    }
}