
#nullable enable

namespace Jina
{
    /// <summary>
    /// Example: {"access":"public","input":[{"label":"Biology","text":"Describe the structure of a plant cell."},{"label":"Creative writing","text":"Write a poem about the ocean."}],"model":"jina-embeddings-v3","num_iters":20}
    /// </summary>
    public sealed partial class EmbeddingsV3CreateTrainingRequest
    {
        /// <summary>
        /// Access level for the training data. Can be 'public' or 'private'.<br/>
        /// Default Value: public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        public string? Access { get; set; }

        /// <summary>
        /// Must be a list of text-label training items with at least two unique labels. For batch training, provide a list with up to 512 items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Jina.TextTrainingItem> Input { get; set; }

        /// <summary>
        /// Text embedding model for zero-shot classification.
        /// </summary>
        /// <default>"jina-embeddings-v3"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "jina-embeddings-v3";

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
        /// Initializes a new instance of the <see cref="EmbeddingsV3CreateTrainingRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Must be a list of text-label training items with at least two unique labels. For batch training, provide a list with up to 512 items.
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
        /// Text embedding model for zero-shot classification.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsV3CreateTrainingRequest(
            global::System.Collections.Generic.IList<global::Jina.TextTrainingItem> input,
            string? access,
            int? numIters,
            string model = "jina-embeddings-v3")
        {
            this.Access = access;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Model = model;
            this.NumIters = numIters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsV3CreateTrainingRequest" /> class.
        /// </summary>
        public EmbeddingsV3CreateTrainingRequest()
        {
        }
    }
}