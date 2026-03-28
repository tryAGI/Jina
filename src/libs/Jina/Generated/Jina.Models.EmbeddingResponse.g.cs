
#nullable enable

namespace Jina
{
    /// <summary>
    /// Response containing embeddings for all input items.
    /// </summary>
    public sealed partial class EmbeddingResponse
    {
        /// <summary>
        /// List of embeddings, one per input item. For sparse embeddings (elser-v2), this is a list of dicts mapping tokens to scores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Jina.SingleEmbeddingData>, global::System.Collections.Generic.IList<global::Jina.MultiEmbeddingData>, global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<global::System.Collections.Generic.IList<global::Jina.SingleEmbeddingData>, global::System.Collections.Generic.IList<global::Jina.MultiEmbeddingData>, global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>> Data { get; set; }

        /// <summary>
        /// The model used to generate the embeddings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Object type, always `list`.<br/>
        /// Default Value: list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Token usage statistics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.EmbeddingUsage, global::Jina.ELSERV2EmbeddingUsage, global::Jina.BaseUsage>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<global::Jina.EmbeddingUsage, global::Jina.ELSERV2EmbeddingUsage, global::Jina.BaseUsage> Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of embeddings, one per input item. For sparse embeddings (elser-v2), this is a list of dicts mapping tokens to scores.
        /// </param>
        /// <param name="model">
        /// The model used to generate the embeddings.
        /// </param>
        /// <param name="object">
        /// Object type, always `list`.<br/>
        /// Default Value: list
        /// </param>
        /// <param name="usage">
        /// Token usage statistics.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingResponse(
            global::Jina.AnyOf<global::System.Collections.Generic.IList<global::Jina.SingleEmbeddingData>, global::System.Collections.Generic.IList<global::Jina.MultiEmbeddingData>, global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, double>>> data,
            string model,
            global::Jina.AnyOf<global::Jina.EmbeddingUsage, global::Jina.ELSERV2EmbeddingUsage, global::Jina.BaseUsage> usage,
            string? @object)
        {
            this.Data = data;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Usage = usage;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingResponse" /> class.
        /// </summary>
        public EmbeddingResponse()
        {
        }
    }
}