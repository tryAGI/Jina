
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// Multimodal reranking for text and images.<br/>
    /// Example: {"documents":[{"image":"https://raw.githubusercontent.com/jina-ai/multimodal-reranker-test/main/paper-11.png"},{"text":"Attention Is All You Need: This groundbreaking paper introduced the Transformer architecture, revolutionizing natural language processing and becoming the foundation for modern large language models like GPT and BERT."},"Recent advances in computer vision have led to the development of vision transformers (ViTs) that achieve state-of-the-art performance on image classification tasks by treating images as sequences of patches.",{"image":"https://raw.githubusercontent.com/jina-ai/multimodal-reranker-test/main/wired-preview.png"},{"text":"Graph Neural Networks: A Review of Methods and Applications. This comprehensive survey covers the latest developments in graph-based machine learning, including graph convolutional networks and graph attention mechanisms."},"Traditional database systems struggle with the volume and variety of modern data workloads, leading to the adoption of distributed computing frameworks like Apache Spark and Hadoop for big data processing."],"model":"jina-reranker-m0","query":"innovative artificial intelligence research papers and visual data analysis","return_documents":false,"top_n":4}
    /// </summary>
    public sealed partial class RerankerM0Request
    {
        /// <summary>
        /// The search query to rank documents against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Number of top results to return. If not set, returns all documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_n")]
        public int? TopN { get; set; }

        /// <summary>
        /// If true (default), includes document content in each result.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_documents")]
        public bool? ReturnDocuments { get; set; }

        /// <summary>
        /// If true, truncates documents exceeding the model's max token limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        public bool? Truncation { get; set; }

        /// <summary>
        /// The multimodal reranking model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.RerankerM0RequestModelJsonConverter))]
        public global::Jina.RerankerM0RequestModel Model { get; set; }

        /// <summary>
        /// Documents to rank: strings, `TextDoc`, or `ImageDoc` objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>> Documents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankerM0Request" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query to rank documents against.
        /// </param>
        /// <param name="topN">
        /// Number of top results to return. If not set, returns all documents.
        /// </param>
        /// <param name="returnDocuments">
        /// If true (default), includes document content in each result.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="truncation">
        /// If true, truncates documents exceeding the model's max token limit.
        /// </param>
        /// <param name="model">
        /// The multimodal reranking model to use.
        /// </param>
        /// <param name="documents">
        /// Documents to rank: strings, `TextDoc`, or `ImageDoc` objects.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankerM0Request(
            string query,
            global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>> documents,
            int? topN,
            bool? returnDocuments,
            bool? truncation,
            global::Jina.RerankerM0RequestModel model)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.TopN = topN;
            this.ReturnDocuments = returnDocuments;
            this.Truncation = truncation;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankerM0Request" /> class.
        /// </summary>
        public RerankerM0Request()
        {
        }
    }
}