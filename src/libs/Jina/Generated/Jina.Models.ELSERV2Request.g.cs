
#nullable enable

namespace Jina
{
    /// <summary>
    /// ELSER v2 request schema.<br/>
    /// Example: {"input":["What is machine learning?","How does AI work?"],"model":"elser-v2","task":"retrieval.query"}
    /// </summary>
    public sealed partial class ELSERV2Request
    {
        /// <summary>
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.ELSERV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ELSERV2RequestEmbeddingTypeItem>, object>))]
        public global::Jina.AnyOf<global::Jina.ELSERV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ELSERV2RequestEmbeddingTypeItem>, object>? EmbeddingType { get; set; }

        /// <summary>
        /// Text to embed: a string, `TextDoc`, or a list of items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> Input { get; set; }

        /// <summary>
        /// The sparse embedding model to use.
        /// </summary>
        /// <default>"elser-v2"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "elser-v2";

        /// <summary>
        /// Task optimization: `retrieval.query` for queries, `retrieval.passage` for documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public global::Jina.ELSERV2RequestTask2? Task { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ELSERV2Request" /> class.
        /// </summary>
        /// <param name="embeddingType">
        /// Output encoding format: `float`, `base64`, `binary`, `ubinary`, or a list of these.
        /// </param>
        /// <param name="input">
        /// Text to embed: a string, `TextDoc`, or a list of items.
        /// </param>
        /// <param name="model">
        /// The sparse embedding model to use.
        /// </param>
        /// <param name="task">
        /// Task optimization: `retrieval.query` for queries, `retrieval.passage` for documents.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ELSERV2Request(
            global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> input,
            global::Jina.AnyOf<global::Jina.ELSERV2RequestEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.ELSERV2RequestEmbeddingTypeItem>, object>? embeddingType,
            global::Jina.ELSERV2RequestTask2? task,
            string model = "elser-v2")
        {
            this.Input = input;
            this.EmbeddingType = embeddingType;
            this.Model = model;
            this.Task = task;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ELSERV2Request" /> class.
        /// </summary>
        public ELSERV2Request()
        {
        }
    }
}