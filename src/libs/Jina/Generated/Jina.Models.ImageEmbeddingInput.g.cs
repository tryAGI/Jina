
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// The input to the API for text embedding. OpenAI compatible
    /// </summary>
    public sealed partial class ImageEmbeddingInput
    {
        /// <summary>
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-clip-v1`,	223M,	768<br/>
        /// - `jina-clip-v2`,	865M,	1024<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2405.20204).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// List of images to embed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ApiSchemasImageImageDoc, global::System.Collections.Generic.IList<global::Jina.ApiSchemasImageImageDoc>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<global::Jina.ApiSchemasImageImageDoc, global::System.Collections.Generic.IList<global::Jina.ApiSchemasImageImageDoc>> Input { get; set; }

        /// <summary>
        /// The format in which you want the embeddings to be returned.Possible value are `float`, `base64`, `binary`, `ubinary` or a list containing any of them. Defaults to `float`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ImageEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ImageEmbeddingInputEmbeddingTypeItem>>))]
        public global::Jina.AnyOf<global::Jina.ImageEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ImageEmbeddingInputEmbeddingTypeItem>>? EmbeddingType { get; set; }

        /// <summary>
        /// Flag to determine if the embeddings should be normalized to have a unit L2 norm<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized")]
        public bool? Normalized { get; set; }

        /// <summary>
        /// Used to convey intended downstream application to help the model produce better embeddings. Must be one of the following values:<br/>
        /// - "retrieval.query": Specifies the given text is a query in a search or retrieval setting.<br/>
        /// - "retrieval.passage": Specifies the given text is a document in a search or retrieval setting.<br/>
        /// - "text-matching": Specifies the given text is used for Semantic Textual Similarity.<br/>
        /// - "classification": Specifies that the embedding is used for classification.<br/>
        /// - "separation": Specifies that the embedding is used for clustering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.ImageEmbeddingInputTaskJsonConverter))]
        public global::Jina.ImageEmbeddingInputTask? Task { get; set; }

        /// <summary>
        /// Used to specify output embedding size. If set, output embeddings will be truncated to the size specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEmbeddingInput" /> class.
        /// </summary>
        /// <param name="model">
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-clip-v1`,	223M,	768<br/>
        /// - `jina-clip-v2`,	865M,	1024<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2405.20204).
        /// </param>
        /// <param name="input">
        /// List of images to embed
        /// </param>
        /// <param name="embeddingType">
        /// The format in which you want the embeddings to be returned.Possible value are `float`, `base64`, `binary`, `ubinary` or a list containing any of them. Defaults to `float`
        /// </param>
        /// <param name="normalized">
        /// Flag to determine if the embeddings should be normalized to have a unit L2 norm<br/>
        /// Default Value: true
        /// </param>
        /// <param name="task">
        /// Used to convey intended downstream application to help the model produce better embeddings. Must be one of the following values:<br/>
        /// - "retrieval.query": Specifies the given text is a query in a search or retrieval setting.<br/>
        /// - "retrieval.passage": Specifies the given text is a document in a search or retrieval setting.<br/>
        /// - "text-matching": Specifies the given text is used for Semantic Textual Similarity.<br/>
        /// - "classification": Specifies that the embedding is used for classification.<br/>
        /// - "separation": Specifies that the embedding is used for clustering.
        /// </param>
        /// <param name="dimensions">
        /// Used to specify output embedding size. If set, output embeddings will be truncated to the size specified.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageEmbeddingInput(
            string model,
            global::Jina.AnyOf<global::Jina.ApiSchemasImageImageDoc, global::System.Collections.Generic.IList<global::Jina.ApiSchemasImageImageDoc>> input,
            global::Jina.AnyOf<global::Jina.ImageEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ImageEmbeddingInputEmbeddingTypeItem>>? embeddingType,
            bool? normalized,
            global::Jina.ImageEmbeddingInputTask? task,
            int? dimensions)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.EmbeddingType = embeddingType;
            this.Normalized = normalized;
            this.Task = task;
            this.Dimensions = dimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEmbeddingInput" /> class.
        /// </summary>
        public ImageEmbeddingInput()
        {
        }
    }
}