
#nullable enable

namespace Jina
{
    /// <summary>
    /// Jina Embeddings v3 with task-specific optimization and flexible dimensions.<br/>
    /// Example: {"dimensions":512,"embedding_type":"float","input":["A beautiful sunset over the beach"],"late_chunking":false,"model":"jina-embeddings-v3","normalized":true,"task":"retrieval.query"}
    /// </summary>
    public sealed partial class EmbeddingsV3Request
    {
        /// <summary>
        /// Number of dimensions for the output embedding. Range: 1-1024.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.EmbeddingsV3RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>, object>))]
        public global::Jina.AnyOf<global::Jina.EmbeddingsV3RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>, object>? EmbeddingType { get; set; }

        /// <summary>
        /// Text to embed: a string, `TextDoc`, or a list of items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> Input { get; set; }

        /// <summary>
        /// If true, concatenates all inputs and processes as one sequence before splitting. Useful for context across chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("late_chunking")]
        public bool? LateChunking { get; set; }

        /// <summary>
        /// The embedding model to use.
        /// </summary>
        /// <default>"jina-embeddings-v3"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "jina-embeddings-v3";

        /// <summary>
        /// If true (default), embeddings are L2-normalized to unit length.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized")]
        public bool? Normalized { get; set; }

        /// <summary>
        /// Task optimization: `retrieval.query` for queries, `retrieval.passage` for documents, `text-matching` for similarity, `classification`, or `separation` for clustering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public global::Jina.EmbeddingsV3RequestTask2? Task { get; set; }

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
        /// Initializes a new instance of the <see cref="EmbeddingsV3Request" /> class.
        /// </summary>
        /// <param name="dimensions">
        /// Number of dimensions for the output embedding. Range: 1-1024.
        /// </param>
        /// <param name="embeddingType">
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </param>
        /// <param name="input">
        /// Text to embed: a string, `TextDoc`, or a list of items.
        /// </param>
        /// <param name="lateChunking">
        /// If true, concatenates all inputs and processes as one sequence before splitting. Useful for context across chunks.
        /// </param>
        /// <param name="model">
        /// The embedding model to use.
        /// </param>
        /// <param name="normalized">
        /// If true (default), embeddings are L2-normalized to unit length.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="task">
        /// Task optimization: `retrieval.query` for queries, `retrieval.passage` for documents, `text-matching` for similarity, `classification`, or `separation` for clustering.
        /// </param>
        /// <param name="truncate">
        /// If true, truncates input exceeding the model's max token limit instead of returning an error.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsV3Request(
            global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> input,
            int? dimensions,
            global::Jina.AnyOf<global::Jina.EmbeddingsV3RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV3RequestEmbeddingTypeItem>, object>? embeddingType,
            bool? lateChunking,
            bool? normalized,
            global::Jina.EmbeddingsV3RequestTask2? task,
            bool? truncate,
            string model = "jina-embeddings-v3")
        {
            this.Input = input;
            this.Dimensions = dimensions;
            this.EmbeddingType = embeddingType;
            this.LateChunking = lateChunking;
            this.Model = model;
            this.Normalized = normalized;
            this.Task = task;
            this.Truncate = truncate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsV3Request" /> class.
        /// </summary>
        public EmbeddingsV3Request()
        {
        }
    }
}