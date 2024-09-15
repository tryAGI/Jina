
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// The input to the API for text embedding. OpenAI compatible
    /// </summary>
    public sealed partial class MixedEmbeddingInput
    {
        /// <summary>
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-clip-v1`,	223M,	768<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2405.20204).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// List of text and images to embed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.ImageDoc, global::Jina.ApiSchemasEmbeddingTextDoc, string>> Input { get; set; }

        /// <summary>
        /// The format in which you want the embeddings to be returned.Possible value are `float`, `base64`, `binary`, `ubinary` or a list containing any of them. Defaults to `float`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::Jina.AnyOf<global::Jina.MixedEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.MixedEmbeddingInputEmbeddingTypeItem>>? EmbeddingType { get; set; }

        /// <summary>
        /// Flag to determine if the embeddings should be normalized to have a unit L2 norm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized")]
        public bool Normalized { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}