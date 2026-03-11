
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// CLIP v1 multimodal model for images and text in a shared vector space.<br/>
    /// Example: {"embedding_type":"float","input":[{"image":"https://i.ibb.co/nQNGqL0/beach1.jpg"},"A beautiful sunset over the beach"],"model":"jina-clip-v1","normalized":true}
    /// </summary>
    public sealed partial class ClipV1Request
    {
        /// <summary>
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ClipV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ClipV1RequestEmbeddingTypeItem>>))]
        public global::Jina.AnyOf<global::Jina.ClipV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ClipV1RequestEmbeddingTypeItem>>? EmbeddingType { get; set; }

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
        /// The CLIP model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.ClipV1RequestModelJsonConverter))]
        public global::Jina.ClipV1RequestModel Model { get; set; }

        /// <summary>
        /// Content to embed: a string, `TextDoc`, `ImageDoc`, `PDFDoc`, or a list of items. PDFs must be sent individually. Images up to 8MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>> Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipV1Request" /> class.
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
        /// The CLIP model to use.
        /// </param>
        /// <param name="input">
        /// Content to embed: a string, `TextDoc`, `ImageDoc`, `PDFDoc`, or a list of items. PDFs must be sent individually. Images up to 8MB.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClipV1Request(
            global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>> input,
            global::Jina.AnyOf<global::Jina.ClipV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ClipV1RequestEmbeddingTypeItem>>? embeddingType,
            bool? normalized,
            bool? truncate,
            global::Jina.ClipV1RequestModel model)
        {
            this.Input = input;
            this.EmbeddingType = embeddingType;
            this.Normalized = normalized;
            this.Truncate = truncate;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipV1Request" /> class.
        /// </summary>
        public ClipV1Request()
        {
        }
    }
}