
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// Classification result for one input item.
    /// </summary>
    public sealed partial class ClassificationPrediction
    {
        /// <summary>
        /// Object type, always `classification`.<br/>
        /// Default Value: classification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Position of this result in the input list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Predicted label, or a dict of labels per group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<string, global::System.Collections.Generic.Dictionary<string, string>> Prediction { get; set; }

        /// <summary>
        /// Confidence score, or a dict of scores per group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<double?, global::System.Collections.Generic.Dictionary<string, double>> Score { get; set; }

        /// <summary>
        /// All candidate labels with scores, or a dict per group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>>> Predictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationPrediction" /> class.
        /// </summary>
        /// <param name="object">
        /// Object type, always `classification`.<br/>
        /// Default Value: classification
        /// </param>
        /// <param name="index">
        /// Position of this result in the input list.
        /// </param>
        /// <param name="prediction">
        /// Predicted label, or a dict of labels per group.
        /// </param>
        /// <param name="score">
        /// Confidence score, or a dict of scores per group.
        /// </param>
        /// <param name="predictions">
        /// All candidate labels with scores, or a dict per group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassificationPrediction(
            int index,
            global::Jina.AnyOf<string, global::System.Collections.Generic.Dictionary<string, string>> prediction,
            global::Jina.AnyOf<double?, global::System.Collections.Generic.Dictionary<string, double>> score,
            global::Jina.AnyOf<global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Jina.ClassificationPredictionLabel>>> predictions,
            string? @object)
        {
            this.Index = index;
            this.Prediction = prediction;
            this.Score = score;
            this.Predictions = predictions;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationPrediction" /> class.
        /// </summary>
        public ClassificationPrediction()
        {
        }
    }
}