
#nullable enable

namespace Jina
{
    /// <summary>
    /// A label with its confidence score.
    /// </summary>
    public sealed partial class ClassificationPredictionLabel
    {
        /// <summary>
        /// The candidate label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Confidence score for this label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationPredictionLabel" /> class.
        /// </summary>
        /// <param name="label">
        /// The candidate label.
        /// </param>
        /// <param name="score">
        /// Confidence score for this label.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassificationPredictionLabel(
            string label,
            double score)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationPredictionLabel" /> class.
        /// </summary>
        public ClassificationPredictionLabel()
        {
        }
    }
}