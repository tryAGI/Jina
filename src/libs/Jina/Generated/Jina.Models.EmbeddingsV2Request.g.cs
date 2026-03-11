
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// Jina Embeddings v2 text embedding models.<br/>
    /// Example: {"embedding_type":"float","input":["A beautiful sunset over the beach","Jina AI - Your Search Foundation - Supercharged"],"model":"jina-embeddings-v2-base-en","normalized":true,"truncate":false}
    /// </summary>
    public sealed partial class EmbeddingsV2Request
    {
        /// <summary>
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.EmbeddingsV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>, object>))]
        public global::Jina.AnyOf<global::Jina.EmbeddingsV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>, object>? EmbeddingType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.EmbeddingsV2RequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.EmbeddingsV2RequestModel Model { get; set; }

        /// <summary>
        /// Text to embed: a string, `TextDoc`, or a list of items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsV2Request" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsV2Request(
            global::Jina.EmbeddingsV2RequestModel model,
            global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> input,
            global::Jina.AnyOf<global::Jina.EmbeddingsV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV2RequestEmbeddingTypeItem>, object>? embeddingType,
            bool? normalized,
            bool? truncate)
        {
            this.Model = model;
            this.Input = input;
            this.EmbeddingType = embeddingType;
            this.Normalized = normalized;
            this.Truncate = truncate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsV2Request" /> class.
        /// </summary>
        public EmbeddingsV2Request()
        {
        }
    }
}