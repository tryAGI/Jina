
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// ColBERT v1 for token-level late interaction retrieval.<br/>
    /// Example: {"embedding_type":"float","input":["A beautiful sunset over the beach","Jina AI - Your Search Foundation - Supercharged"],"input_type":"document","model":"jina-colbert-v1-en"}
    /// </summary>
    public sealed partial class ColbertV1Request
    {
        /// <summary>
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ColbertV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV1RequestEmbeddingTypeItem>>))]
        public global::Jina.AnyOf<global::Jina.ColbertV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV1RequestEmbeddingTypeItem>>? EmbeddingType { get; set; }

        /// <summary>
        /// The ColBERT model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.ColbertV1RequestModelJsonConverter))]
        public global::Jina.ColbertV1RequestModel Model { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.ColbertV1RequestInputTypeJsonConverter))]
        public global::Jina.ColbertV1RequestInputType? InputType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColbertV1Request" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColbertV1Request(
            global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> input,
            global::Jina.AnyOf<global::Jina.ColbertV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV1RequestEmbeddingTypeItem>>? embeddingType,
            global::Jina.ColbertV1RequestModel model,
            global::Jina.ColbertV1RequestInputType? inputType)
        {
            this.Input = input;
            this.EmbeddingType = embeddingType;
            this.Model = model;
            this.InputType = inputType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColbertV1Request" /> class.
        /// </summary>
        public ColbertV1Request()
        {
        }
    }
}