
#nullable enable

namespace Jina
{
    /// <summary>
    /// Example: {"access":"private","input":[{"label":"Dog","text":"A dog playing in the park."},{"image":"https://images.unsplash.com/photo-1465101046530-73398c7f28ca","label":"Rocket"}],"model":"jina-embeddings-v4","num_iters":25}
    /// </summary>
    public sealed partial class EmbeddingsV4CreateTrainingRequest
    {
        /// <summary>
        /// Access level for the training data. Can be 'public' or 'private'.<br/>
        /// Default Value: public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        public string? Access { get; set; }

        /// <summary>
        /// Must be a list of text-label or image-label training items with at least two unique labels. For batch training, provide a list with up to 512 items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>> Input { get; set; }

        /// <summary>
        /// Multimodal embedding model for zero-shot classification.
        /// </summary>
        /// <default>"jina-embeddings-v4"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "jina-embeddings-v4";

        /// <summary>
        /// Number of iterations for the training process.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_iters")]
        public int? NumIters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsV4CreateTrainingRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Must be a list of text-label or image-label training items with at least two unique labels. For batch training, provide a list with up to 512 items.
        /// </param>
        /// <param name="access">
        /// Access level for the training data. Can be 'public' or 'private'.<br/>
        /// Default Value: public
        /// </param>
        /// <param name="numIters">
        /// Number of iterations for the training process.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="model">
        /// Multimodal embedding model for zero-shot classification.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsV4CreateTrainingRequest(
            global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>> input,
            string? access,
            int? numIters,
            string model = "jina-embeddings-v4")
        {
            this.Access = access;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Model = model;
            this.NumIters = numIters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsV4CreateTrainingRequest" /> class.
        /// </summary>
        public EmbeddingsV4CreateTrainingRequest()
        {
        }
    }
}