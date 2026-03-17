
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// Code embedding model (1.5B) for code search and understanding.
    /// </summary>
    public sealed partial class CodeEmbeddings1500MRequest
    {
        /// <summary>
        /// Number of dimensions for the output embedding. Range: 1-1536.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.CodeEmbeddings1500MRequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>, object>))]
        public global::Jina.AnyOf<global::Jina.CodeEmbeddings1500MRequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>, object>? EmbeddingType { get; set; }

        /// <summary>
        /// Code or text to embed: a string, `TextDoc`, or a list of items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> Input { get; set; }

        /// <summary>
        /// The code embedding model to use.
        /// </summary>
        /// <default>"jina-code-embeddings-1.5b"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "jina-code-embeddings-1.5b";

        /// <summary>
        /// Task type: `nl2code`, `qa`, `code2code`, `code2nl`, or `code2completion`. Use `.query` for queries, `.passage` for documents.<br/>
        /// Default Value: nl2code.query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public global::Jina.CodeEmbeddings1500MRequestTask2? Task { get; set; }

        /// <summary>
        /// If true, truncates input exceeding the model's max token limit instead of returning an error.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncate")]
        public bool? Truncate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeEmbeddings1500MRequest" /> class.
        /// </summary>
        /// <param name="dimensions">
        /// Number of dimensions for the output embedding. Range: 1-1536.
        /// </param>
        /// <param name="embeddingType">
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </param>
        /// <param name="input">
        /// Code or text to embed: a string, `TextDoc`, or a list of items.
        /// </param>
        /// <param name="model">
        /// The code embedding model to use.
        /// </param>
        /// <param name="task">
        /// Task type: `nl2code`, `qa`, `code2code`, `code2nl`, or `code2completion`. Use `.query` for queries, `.passage` for documents.<br/>
        /// Default Value: nl2code.query
        /// </param>
        /// <param name="truncate">
        /// If true, truncates input exceeding the model's max token limit instead of returning an error.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeEmbeddings1500MRequest(
            global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> input,
            int? dimensions,
            global::Jina.AnyOf<global::Jina.CodeEmbeddings1500MRequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.CodeEmbeddings1500MRequestEmbeddingTypeItem>, object>? embeddingType,
            global::Jina.CodeEmbeddings1500MRequestTask2? task,
            bool? truncate,
            string model = "jina-code-embeddings-1.5b")
        {
            this.Input = input;
            this.Dimensions = dimensions;
            this.EmbeddingType = embeddingType;
            this.Model = model;
            this.Task = task;
            this.Truncate = truncate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeEmbeddings1500MRequest" /> class.
        /// </summary>
        public CodeEmbeddings1500MRequest()
        {
        }
    }
}