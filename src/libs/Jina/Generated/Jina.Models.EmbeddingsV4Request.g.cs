
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// Jina Embeddings v4 multimodal model for text, images, and PDFs.
    /// </summary>
    public sealed partial class EmbeddingsV4Request
    {
        /// <summary>
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.EmbeddingsV4RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>, object>))]
        public global::Jina.AnyOf<global::Jina.EmbeddingsV4RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>, object>? EmbeddingType { get; set; }

        /// <summary>
        /// The embedding model to use.
        /// </summary>
        /// <default>"jina-embeddings-v4"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "jina-embeddings-v4";

        /// <summary>
        /// Content to embed: a string, `TextDoc`, `ImageDoc`, `PDFDoc`, or a list of items. PDFs must be sent individually. Images up to 8MB; PDFs up to 8MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>> Input { get; set; } = default!;

        /// <summary>
        /// If true, truncates input exceeding the model's max token limit instead of returning an error.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncate")]
        public bool? Truncate { get; set; }

        /// <summary>
        /// If true, concatenates all text inputs and processes as one sequence before splitting. Only works with text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("late_chunking")]
        public bool? LateChunking { get; set; }

        /// <summary>
        /// Number of dimensions for the output embedding. Range: 1-2048.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// Task optimization: `text-matching` (default), `retrieval.query`, `retrieval.passage`, `code.query`, or `code.passage`.<br/>
        /// Default Value: text-matching
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public global::Jina.EmbeddingsV4RequestTask2? Task { get; set; }

        /// <summary>
        /// If true, returns one embedding per token. Cannot be used with `dimensions`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_multivector")]
        public bool? ReturnMultivector { get; set; }

        /// <summary>
        /// If true, returns tokens alongside multi-vector embeddings. Requires `return_multivector=true`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_tokenized_input")]
        public bool? ReturnTokenizedInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsV4Request" /> class.
        /// </summary>
        /// <param name="embeddingType">
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </param>
        /// <param name="model">
        /// The embedding model to use.
        /// </param>
        /// <param name="input">
        /// Content to embed: a string, `TextDoc`, `ImageDoc`, `PDFDoc`, or a list of items. PDFs must be sent individually. Images up to 8MB; PDFs up to 8MB.
        /// </param>
        /// <param name="truncate">
        /// If true, truncates input exceeding the model's max token limit instead of returning an error.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="lateChunking">
        /// If true, concatenates all text inputs and processes as one sequence before splitting. Only works with text.
        /// </param>
        /// <param name="dimensions">
        /// Number of dimensions for the output embedding. Range: 1-2048.
        /// </param>
        /// <param name="task">
        /// Task optimization: `text-matching` (default), `retrieval.query`, `retrieval.passage`, `code.query`, or `code.passage`.<br/>
        /// Default Value: text-matching
        /// </param>
        /// <param name="returnMultivector">
        /// If true, returns one embedding per token. Cannot be used with `dimensions`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnTokenizedInput">
        /// If true, returns tokens alongside multi-vector embeddings. Requires `return_multivector=true`.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsV4Request(
            global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.PDFDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>> input,
            global::Jina.AnyOf<global::Jina.EmbeddingsV4RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.EmbeddingsV4RequestEmbeddingTypeItem>, object>? embeddingType,
            bool? truncate,
            bool? lateChunking,
            int? dimensions,
            global::Jina.EmbeddingsV4RequestTask2? task,
            bool? returnMultivector,
            bool? returnTokenizedInput,
            string model = "jina-embeddings-v4")
        {
            this.Input = input;
            this.EmbeddingType = embeddingType;
            this.Model = model;
            this.Truncate = truncate;
            this.LateChunking = lateChunking;
            this.Dimensions = dimensions;
            this.Task = task;
            this.ReturnMultivector = returnMultivector;
            this.ReturnTokenizedInput = returnTokenizedInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsV4Request" /> class.
        /// </summary>
        public EmbeddingsV4Request()
        {
        }
    }
}