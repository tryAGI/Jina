
#nullable enable

namespace Jina
{
    /// <summary>
    /// Example: {"classifier_id":"cls-2025-07-15-xyz","input":[{"label":"Physics","text":"Summarize the theory of relativity."},{"image":"https://images.unsplash.com/photo-1506744038136-46273834b3fb","label":"Landscape"},{"label":"Biology","text":"Explain the process of photosynthesis."},{"image":"https://images.unsplash.com/photo-1465101046530-73398c7f28ca","label":"Rocket"}],"num_iters":20}
    /// </summary>
    public sealed partial class UpdateTrainingRequest
    {
        /// <summary>
        /// ID of the classifier to use for few-shot classification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClassifierId { get; set; }

        /// <summary>
        /// Input(s) for updating training. Accepts a `TextTrainingItem`, `ImageTrainingItem`, or a list of them. For batch update, provide a list with up to 512 items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem, global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem, global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>> Input { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateTrainingRequest" /> class.
        /// </summary>
        /// <param name="classifierId">
        /// ID of the classifier to use for few-shot classification.
        /// </param>
        /// <param name="input">
        /// Input(s) for updating training. Accepts a `TextTrainingItem`, `ImageTrainingItem`, or a list of them. For batch update, provide a list with up to 512 items.
        /// </param>
        /// <param name="numIters">
        /// Number of iterations for the training process.<br/>
        /// Default Value: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTrainingRequest(
            string classifierId,
            global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem, global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>>> input,
            int? numIters)
        {
            this.ClassifierId = classifierId ?? throw new global::System.ArgumentNullException(nameof(classifierId));
            this.Input = input;
            this.NumIters = numIters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTrainingRequest" /> class.
        /// </summary>
        public UpdateTrainingRequest()
        {
        }
    }
}