
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// Text reranking request for v1/v2 models.<br/>
    /// Example: {"documents":["Climate Change and Renewable Energy: A Global Perspective. Rising temperatures and extreme weather events are accelerating the transition to solar and wind power worldwide.","Le changement climatique et l\u0027\u00E9nergie renouvelable : une perspective europ\u00E9enne. L\u0027Union europ\u00E9enne investit massivement dans les technologies vertes pour atteindre la neutralit\u00E9 carbone d\u0027ici 2050.","Klimawandel und erneuerbare Energien: Deutsche Energiewende. Deutschland f\u00FChrt die Transformation des Energiesektors durch innovative Technologien und politische Ma\u00DFnahmen an.","\u6C14\u5019\u53D8\u5316\u5BF9\u53EF\u518D\u751F\u80FD\u6E90\u7684\u5F71\u54CD\uFF1A\u4E2D\u56FD\u7684\u7EFF\u8272\u53D1\u5C55\u6218\u7565\u3002\u4E2D\u56FD\u6B63\u5728\u5927\u529B\u63A8\u8FDB\u592A\u9633\u80FD\u548C\u98CE\u80FD\u9879\u76EE\uFF0C\u4EE5\u5B9E\u73B0\u78B3\u4E2D\u548C\u76EE\u6807\u3002","Artificial Intelligence in Healthcare: Revolutionizing Medical Diagnosis. AI-powered systems are improving accuracy in disease detection and treatment recommendations.","Blockchain Technology: Transforming Financial Services. Decentralized finance applications are reshaping traditional banking and payment systems."],"model":"jina-reranker-v2-base-multilingual","query":"Climate change impact on renewable energy adoption","return_documents":false,"top_n":4}
    /// </summary>
    public sealed partial class TextRerankerRequest
    {
        /// <summary>
        /// The search query to rank documents against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Query { get; set; } = default!;

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
        /// The reranking model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.TextRerankerRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Jina.TextRerankerRequestModel Model { get; set; } = default!;

        /// <summary>
        /// Documents to rank: strings or `TextDoc` objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>> Documents { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextRerankerRequest" /> class.
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
        /// The reranking model to use.
        /// </param>
        /// <param name="documents">
        /// Documents to rank: strings or `TextDoc` objects.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextRerankerRequest(
            string query,
            global::Jina.TextRerankerRequestModel model,
            global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>> documents,
            int? topN,
            bool? returnDocuments,
            bool? truncation)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Model = model;
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.TopN = topN;
            this.ReturnDocuments = returnDocuments;
            this.Truncation = truncation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextRerankerRequest" /> class.
        /// </summary>
        public TextRerankerRequest()
        {
        }
    }
}