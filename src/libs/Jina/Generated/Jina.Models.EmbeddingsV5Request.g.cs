
#nullable enable

namespace Jina
{
    /// <summary>
    /// Jina Embeddings v5, with task-specific adapters and truncatable<br/>
    /// dimensions. Text, images, video, audio and PDFs share one vector space, so<br/>
    /// a query in any of them retrieves any other; the `omni` names are the ones<br/>
    /// to reach for when the corpus is not text.<br/>
    /// Each list item is one modality, except a `MergedContentGroup`<br/>
    /// (`{"content": [...]}`), which fuses several chunks into a single embedding<br/>
    /// in one forward pass.
    /// </summary>
    public sealed partial class EmbeddingsV5Request
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.EmbeddingsV5RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>>))]
        public global::Jina.AnyOf<global::Jina.EmbeddingsV5RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>>? EmbeddingType { get; set; }

        /// <summary>
        /// Content to embed: a string, `TextDoc`, `ImageDoc`, `VideoDoc`, `AudioDoc`, `PDFDoc`, or a list of these. A list item may also be a `{content: [...]}` group, fused into one embedding. A PDF must be sent on its own, not inside a list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.PDFDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.MergedContentGroup>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.PDFDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.MergedContentGroup>>> Input { get; set; }

        /// <summary>
        /// The embedding model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.EmbeddingsV5RequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.EmbeddingsV5RequestModel Model { get; set; }

        /// <summary>
        /// If true (default), embeddings are L2-normalized to unit length.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized")]
        public bool? Normalized { get; set; }

        /// <summary>
        /// Task optimization: `retrieval.query` for queries, `retrieval.passage` for documents, `text-matching` for similarity, `clustering`, or `classification`.<br/>
        /// Default Value: text-matching
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public global::Jina.EmbeddingsV5RequestTask? Task { get; set; }

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
        /// Initializes a new instance of the <see cref="EmbeddingsV5Request" /> class.
        /// </summary>
        /// <param name="input">
        /// Content to embed: a string, `TextDoc`, `ImageDoc`, `VideoDoc`, `AudioDoc`, `PDFDoc`, or a list of these. A list item may also be a `{content: [...]}` group, fused into one embedding. A PDF must be sent on its own, not inside a list.
        /// </param>
        /// <param name="model">
        /// The embedding model to use.
        /// </param>
        /// <param name="dimensions">
        /// Number of dimensions for the output embedding. Range: 1-1024.
        /// </param>
        /// <param name="embeddingType">
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </param>
        /// <param name="normalized">
        /// If true (default), embeddings are L2-normalized to unit length.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="task">
        /// Task optimization: `retrieval.query` for queries, `retrieval.passage` for documents, `text-matching` for similarity, `clustering`, or `classification`.<br/>
        /// Default Value: text-matching
        /// </param>
        /// <param name="truncate">
        /// If true, truncates input exceeding the model's max token limit instead of returning an error.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsV5Request(
            global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.PDFDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc, global::Jina.MergedContentGroup>>> input,
            global::Jina.EmbeddingsV5RequestModel model,
            int? dimensions,
            global::Jina.AnyOf<global::Jina.EmbeddingsV5RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV5RequestEmbeddingTypeItem>>? embeddingType,
            bool? normalized,
            global::Jina.EmbeddingsV5RequestTask? task,
            bool? truncate)
        {
            this.Dimensions = dimensions;
            this.EmbeddingType = embeddingType;
            this.Input = input;
            this.Model = model;
            this.Normalized = normalized;
            this.Task = task;
            this.Truncate = truncate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsV5Request" /> class.
        /// </summary>
        public EmbeddingsV5Request()
        {
        }

    }
}