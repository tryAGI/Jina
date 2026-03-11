
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// Multi-vector embedding result (one vector per token).
    /// </summary>
    public sealed partial class MultiEmbeddingData
    {
        /// <summary>
        /// Object type, always `embeddings` for multi-vector output.<br/>
        /// Default Value: embeddings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Position of this result in the input list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Per-token embedding vectors. Each is a list of floats or base64 string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>> Embeddings { get; set; } = default!;

        /// <summary>
        /// Tokens corresponding to each embedding, if `return_tokenized_input=true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenized_input")]
        public global::System.Collections.Generic.IList<string>? TokenizedInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiEmbeddingData" /> class.
        /// </summary>
        /// <param name="object">
        /// Object type, always `embeddings` for multi-vector output.<br/>
        /// Default Value: embeddings
        /// </param>
        /// <param name="index">
        /// Position of this result in the input list.
        /// </param>
        /// <param name="embeddings">
        /// Per-token embedding vectors. Each is a list of floats or base64 string.
        /// </param>
        /// <param name="tokenizedInput">
        /// Tokens corresponding to each embedding, if `return_tokenized_input=true`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiEmbeddingData(
            int index,
            global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>> embeddings,
            string? @object,
            global::System.Collections.Generic.IList<string>? tokenizedInput)
        {
            this.Index = index;
            this.Embeddings = embeddings;
            this.Object = @object;
            this.TokenizedInput = tokenizedInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiEmbeddingData" /> class.
        /// </summary>
        public MultiEmbeddingData()
        {
        }
    }
}