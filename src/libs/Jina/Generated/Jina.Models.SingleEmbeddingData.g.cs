
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// Single embedding result for one input item.
    /// </summary>
    public sealed partial class SingleEmbeddingData
    {
        /// <summary>
        /// Object type, always `embedding`.<br/>
        /// Default Value: embedding
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Position of this embedding in the input list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The embedding vector: a list of floats for dense embeddings, a dict of token-&gt;score for sparse embeddings, or a base64 string for other encodings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<string, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>> Embedding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleEmbeddingData" /> class.
        /// </summary>
        /// <param name="object">
        /// Object type, always `embedding`.<br/>
        /// Default Value: embedding
        /// </param>
        /// <param name="index">
        /// Position of this embedding in the input list.
        /// </param>
        /// <param name="embedding">
        /// The embedding vector: a list of floats for dense embeddings, a dict of token-&gt;score for sparse embeddings, or a base64 string for other encodings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SingleEmbeddingData(
            int index,
            global::Jina.AnyOf<string, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>> embedding,
            string? @object)
        {
            this.Index = index;
            this.Embedding = embedding;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleEmbeddingData" /> class.
        /// </summary>
        public SingleEmbeddingData()
        {
        }
    }
}