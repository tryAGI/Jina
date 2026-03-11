
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// Few-shot classification using a trained classifier.<br/>
    /// Example: {"classifier_id":"cls-2024-07-14-xyz","input":["Summarize the main points of the article.","Classify the following statement: \u0027The service was prompt and friendly.\u0027"]}
    /// </summary>
    public sealed partial class FewShotClassificationRequest
    {
        /// <summary>
        /// ID of the trained classifier to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClassifierId { get; set; }

        /// <summary>
        /// Text to classify: a string, `TextDoc`, or list of up to 512 items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FewShotClassificationRequest" /> class.
        /// </summary>
        /// <param name="classifierId">
        /// ID of the trained classifier to use.
        /// </param>
        /// <param name="input">
        /// Text to classify: a string, `TextDoc`, or list of up to 512 items.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FewShotClassificationRequest(
            string classifierId,
            global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> input)
        {
            this.ClassifierId = classifierId ?? throw new global::System.ArgumentNullException(nameof(classifierId));
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FewShotClassificationRequest" /> class.
        /// </summary>
        public FewShotClassificationRequest()
        {
        }
    }
}