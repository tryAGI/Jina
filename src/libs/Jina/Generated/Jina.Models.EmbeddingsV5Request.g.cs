
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// Jina Embeddings v5 text-only model with task-specific LoRA adapters and flexible dimensions.<br/>
    /// Example: {"dimensions":512,"embedding_type":"float","input":["A beautiful sunset over the beach"],"model":"jina-embeddings-v5-text-small","normalized":true,"task":"retrieval.query"}
    /// </summary>
    public sealed partial class EmbeddingsV5Request
    {
        /// <summary>
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.EmbeddingsV5RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>>))]
        public global::Jina.AnyOf<global::Jina.EmbeddingsV5RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>>? EmbeddingType { get; set; }

        /// <summary>
        /// If true (default), embeddings are L2-normalized to unit length.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized")]
        public bool? Normalized { get; set; }

        /// <summary>
        /// If true, truncates input exceeding the model's max token limit instead of returning an error.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncate")]
        public bool? Truncate { get; set; }

        /// <summary>
        /// The embedding model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.EmbeddingsV5RequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.EmbeddingsV5RequestModel Model { get; set; }

        /// <summary>
        /// Text to embed: a string, `TextDoc`, or a list of items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> Input { get; set; }

        /// <summary>
        /// Task optimization: `retrieval.query` for queries, `retrieval.passage` for documents, `text-matching` for similarity, `clustering`, or `classification`.<br/>
        /// Default Value: text-matching
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.EmbeddingsV5RequestTaskJsonConverter))]
        public global::Jina.EmbeddingsV5RequestTask? Task { get; set; }

        /// <summary>
        /// Number of dimensions for the output embedding. Range: 1-1024.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsV5Request" /> class.
        /// </summary>
        /// <param name="embeddingType">
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </param>
        /// <param name="normalized">
        /// If true (default), embeddings are L2-normalized to unit length.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="truncate">
        /// If true, truncates input exceeding the model's max token limit instead of returning an error.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="model">
        /// The embedding model to use.
        /// </param>
        /// <param name="input">
        /// Text to embed: a string, `TextDoc`, or a list of items.
        /// </param>
        /// <param name="task">
        /// Task optimization: `retrieval.query` for queries, `retrieval.passage` for documents, `text-matching` for similarity, `clustering`, or `classification`.<br/>
        /// Default Value: text-matching
        /// </param>
        /// <param name="dimensions">
        /// Number of dimensions for the output embedding. Range: 1-1024.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsV5Request(
            global::Jina.EmbeddingsV5RequestModel model,
            global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> input,
            global::Jina.AnyOf<global::Jina.EmbeddingsV5RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>>? embeddingType,
            bool? normalized,
            bool? truncate,
            global::Jina.EmbeddingsV5RequestTask? task,
            int? dimensions)
        {
            this.Model = model;
            this.Input = input;
            this.EmbeddingType = embeddingType;
            this.Normalized = normalized;
            this.Truncate = truncate;
            this.Task = task;
            this.Dimensions = dimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsV5Request" /> class.
        /// </summary>
        public EmbeddingsV5Request()
        {
        }
    }
}