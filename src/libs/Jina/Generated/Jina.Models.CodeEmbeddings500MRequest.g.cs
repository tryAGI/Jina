
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// Code embedding model (500M) for code search and understanding.<br/>
    /// Example: {"dimensions":512,"embedding_type":"float","input":["import * as ElementPlusIconsVue from \u0027@element-plus/icons-vue\u0027\nconst app = createApp(App)\nfor (const [key, component] of Object.entries(ElementPlusIconsVue)) {\n  app.component(key, component)\n}"],"model":"jina-code-embeddings-0.5b","task":"nl2code.passage"}
    /// </summary>
    public sealed partial class CodeEmbeddings500MRequest
    {
        /// <summary>
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.CodeEmbeddings500MRequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>>))]
        public global::Jina.AnyOf<global::Jina.CodeEmbeddings500MRequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>>? EmbeddingType { get; set; }

        /// <summary>
        /// The code embedding model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.CodeEmbeddings500MRequestModelJsonConverter))]
        public global::Jina.CodeEmbeddings500MRequestModel Model { get; set; }

        /// <summary>
        /// Code or text to embed: a string, `TextDoc`, or a list of items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> Input { get; set; }

        /// <summary>
        /// If true, truncates input exceeding the model's max token limit instead of returning an error.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncate")]
        public bool? Truncate { get; set; }

        /// <summary>
        /// Number of dimensions for the output embedding. Range: 1-896.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// Task type: `nl2code`, `qa`, `code2code`, `code2nl`, or `code2completion`. Use `.query` for queries, `.passage` for documents.<br/>
        /// Default Value: nl2code.query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.CodeEmbeddings500MRequestTaskJsonConverter))]
        public global::Jina.CodeEmbeddings500MRequestTask? Task { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeEmbeddings500MRequest" /> class.
        /// </summary>
        /// <param name="embeddingType">
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </param>
        /// <param name="model">
        /// The code embedding model to use.
        /// </param>
        /// <param name="input">
        /// Code or text to embed: a string, `TextDoc`, or a list of items.
        /// </param>
        /// <param name="truncate">
        /// If true, truncates input exceeding the model's max token limit instead of returning an error.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dimensions">
        /// Number of dimensions for the output embedding. Range: 1-896.
        /// </param>
        /// <param name="task">
        /// Task type: `nl2code`, `qa`, `code2code`, `code2nl`, or `code2completion`. Use `.query` for queries, `.passage` for documents.<br/>
        /// Default Value: nl2code.query
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeEmbeddings500MRequest(
            global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> input,
            global::Jina.AnyOf<global::Jina.CodeEmbeddings500MRequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings500MRequestEmbeddingTypeItem>>? embeddingType,
            global::Jina.CodeEmbeddings500MRequestModel model,
            bool? truncate,
            int? dimensions,
            global::Jina.CodeEmbeddings500MRequestTask? task)
        {
            this.Input = input;
            this.EmbeddingType = embeddingType;
            this.Model = model;
            this.Truncate = truncate;
            this.Dimensions = dimensions;
            this.Task = task;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeEmbeddings500MRequest" /> class.
        /// </summary>
        public CodeEmbeddings500MRequest()
        {
        }
    }
}