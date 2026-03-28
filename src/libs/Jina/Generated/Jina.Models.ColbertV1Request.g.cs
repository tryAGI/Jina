
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ColbertV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV1RequestEmbeddingTypeItem>, object>))]
        public global::Jina.AnyOf<global::Jina.ColbertV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV1RequestEmbeddingTypeItem>, object>? EmbeddingType { get; set; }

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
        public global::Jina.ColbertV1RequestInputType2? InputType { get; set; }

        /// <summary>
        /// The ColBERT model to use.
        /// </summary>
        /// <default>"jina-colbert-v1-en"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "jina-colbert-v1-en";

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
        /// <param name="input">
        /// Text to embed: a string, `TextDoc`, or a list of items.
        /// </param>
        /// <param name="inputType">
        /// Role of the input: `query` for search queries, `document` for passages.<br/>
        /// Default Value: document
        /// </param>
        /// <param name="model">
        /// The ColBERT model to use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColbertV1Request(
            global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> input,
            global::Jina.AnyOf<global::Jina.ColbertV1RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ColbertV1RequestEmbeddingTypeItem>, object>? embeddingType,
            global::Jina.ColbertV1RequestInputType2? inputType,
            string model = "jina-colbert-v1-en")
        {
            this.Input = input;
            this.EmbeddingType = embeddingType;
            this.InputType = inputType;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColbertV1Request" /> class.
        /// </summary>
        public ColbertV1Request()
        {
        }
    }
}