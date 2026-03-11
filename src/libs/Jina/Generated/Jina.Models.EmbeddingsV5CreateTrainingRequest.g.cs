
#nullable enable

namespace Jina
{
    /// <summary>
    /// Example: {"access":"public","input":[{"label":"Biology","text":"Describe the structure of a plant cell."},{"label":"Creative writing","text":"Write a poem about the ocean."}],"model":"jina-embeddings-v5-text-small","num_iters":20}
    /// </summary>
    public sealed partial class EmbeddingsV5CreateTrainingRequest
    {
        /// <summary>
        /// Access level for the training data. Can be 'public' or 'private'.<br/>
        /// Default Value: public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        public string? Access { get; set; }

        /// <summary>
        /// Number of iterations for the training process.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_iters")]
        public int? NumIters { get; set; }

        /// <summary>
        /// Text embedding model for zero-shot classification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.EmbeddingsV5CreateTrainingRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Jina.EmbeddingsV5CreateTrainingRequestModel Model { get; set; } = default!;

        /// <summary>
        /// Must be a list of text-label training items with at least two unique labels. For batch training, provide a list with up to 512 items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Jina.TextTrainingItem> Input { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsV5CreateTrainingRequest" /> class.
        /// </summary>
        /// <param name="access">
        /// Access level for the training data. Can be 'public' or 'private'.<br/>
        /// Default Value: public
        /// </param>
        /// <param name="numIters">
        /// Number of iterations for the training process.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="model">
        /// Text embedding model for zero-shot classification.
        /// </param>
        /// <param name="input">
        /// Must be a list of text-label training items with at least two unique labels. For batch training, provide a list with up to 512 items.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsV5CreateTrainingRequest(
            global::Jina.EmbeddingsV5CreateTrainingRequestModel model,
            global::System.Collections.Generic.IList<global::Jina.TextTrainingItem> input,
            string? access,
            int? numIters)
        {
            this.Model = model;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Access = access;
            this.NumIters = numIters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsV5CreateTrainingRequest" /> class.
        /// </summary>
        public EmbeddingsV5CreateTrainingRequest()
        {
        }
    }
}