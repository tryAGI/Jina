
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// ColBERT v2 with Matryoshka representation learning for flexible dimensions.<br/>
    /// Example: {"dimensions":128,"embedding_type":"float","input":["A beautiful sunset over the beach"],"input_type":"query","model":"jina-colbert-v2"}
    /// </summary>
    public sealed partial class ColbertV2Request
    {
        /// <summary>
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ColbertV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV2RequestEmbeddingTypeItem>>))]
        public global::Jina.AnyOf<global::Jina.ColbertV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV2RequestEmbeddingTypeItem>>? EmbeddingType { get; set; }

        /// <summary>
        /// The ColBERT model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.ColbertV2RequestModelJsonConverter))]
        public global::Jina.ColbertV2RequestModel Model { get; set; }

        /// <summary>
        /// Text to embed: a string, `TextDoc`, or a list of items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> Input { get; set; }

        /// <summary>
        /// Role of the input: `query` for search queries, `document` for passages.<br/>
        /// Default Value: document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.ColbertV2RequestInputTypeJsonConverter))]
        public global::Jina.ColbertV2RequestInputType? InputType { get; set; }

        /// <summary>
        /// Dimensions per token: `64`, `96`, or `128`. Defaults to 128.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColbertV2Request" /> class.
        /// </summary>
        /// <param name="embeddingType">
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </param>
        /// <param name="model">
        /// The ColBERT model to use.
        /// </param>
        /// <param name="input">
        /// Text to embed: a string, `TextDoc`, or a list of items.
        /// </param>
        /// <param name="inputType">
        /// Role of the input: `query` for search queries, `document` for passages.<br/>
        /// Default Value: document
        /// </param>
        /// <param name="dimensions">
        /// Dimensions per token: `64`, `96`, or `128`. Defaults to 128.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColbertV2Request(
            global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> input,
            global::Jina.AnyOf<global::Jina.ColbertV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV2RequestEmbeddingTypeItem>>? embeddingType,
            global::Jina.ColbertV2RequestModel model,
            global::Jina.ColbertV2RequestInputType? inputType,
            int? dimensions)
        {
            this.Input = input;
            this.EmbeddingType = embeddingType;
            this.Model = model;
            this.InputType = inputType;
            this.Dimensions = dimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColbertV2Request" /> class.
        /// </summary>
        public ColbertV2Request()
        {
        }
    }
}