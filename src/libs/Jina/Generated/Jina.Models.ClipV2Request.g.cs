
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// CLIP v2 with Matryoshka representation learning for flexible dimensions.<br/>
    /// Example: {"dimensions":512,"embedding_type":"float","input":[{"image":"https://i.ibb.co/nQNGqL0/beach1.jpg"},"Jina AI - Your Search Foundation - Supercharged"],"model":"jina-clip-v2","normalized":true,"task":"retrieval.query"}
    /// </summary>
    public sealed partial class ClipV2Request
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ClipV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ClipV2RequestEmbeddingTypeItem>, object>))]
        public global::Jina.AnyOf<global::Jina.ClipV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ClipV2RequestEmbeddingTypeItem>, object>? EmbeddingType { get; set; }

        /// <summary>
        /// Content to embed: a string, `TextDoc`, `ImageDoc`, `PDFDoc`, or a list of items. PDFs must be sent individually. Images up to 8MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>> Input { get; set; }

        /// <summary>
        /// The CLIP model to use.
        /// </summary>
        /// <default>"jina-clip-v2"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "jina-clip-v2";

        /// <summary>
        /// If true (default), embeddings are L2-normalized to unit length.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized")]
        public bool? Normalized { get; set; }

        /// <summary>
        /// Set to `retrieval.query` to optimize for search queries. Leave unset for documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public string? Task { get; set; }

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
        /// Initializes a new instance of the <see cref="ClipV2Request" /> class.
        /// </summary>
        /// <param name="dimensions">
        /// Number of dimensions for the output embedding. Range: 1-1024.
        /// </param>
        /// <param name="embeddingType">
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </param>
        /// <param name="input">
        /// Content to embed: a string, `TextDoc`, `ImageDoc`, `PDFDoc`, or a list of items. PDFs must be sent individually. Images up to 8MB.
        /// </param>
        /// <param name="model">
        /// The CLIP model to use.
        /// </param>
        /// <param name="normalized">
        /// If true (default), embeddings are L2-normalized to unit length.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="task">
        /// Set to `retrieval.query` to optimize for search queries. Leave unset for documents.
        /// </param>
        /// <param name="truncate">
        /// If true, truncates input exceeding the model's max token limit instead of returning an error.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClipV2Request(
            global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>> input,
            int? dimensions,
            global::Jina.AnyOf<global::Jina.ClipV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ClipV2RequestEmbeddingTypeItem>, object>? embeddingType,
            bool? normalized,
            string? task,
            bool? truncate,
            string model = "jina-clip-v2")
        {
            this.Input = input;
            this.Dimensions = dimensions;
            this.EmbeddingType = embeddingType;
            this.Model = model;
            this.Normalized = normalized;
            this.Task = task;
            this.Truncate = truncate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipV2Request" /> class.
        /// </summary>
        public ClipV2Request()
        {
        }
    }
}