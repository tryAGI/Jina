
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// Zero-shot classification using CLIP for text and images.<br/>
    /// Example: {"input":["A photo of a cat sitting on a windowsill.",{"image":"https://images.unsplash.com/photo-1518717758536-85ae29035b6d"}],"labels":["Animal","Object","Scene"],"model":"jina-clip-v2"}
    /// </summary>
    public sealed partial class ClipZeroShotClassificationRequest
    {
        /// <summary>
        /// Candidate labels: a list of up to 512 labels, or a dict of up to 8 groups with max 64 labels each.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>> Labels { get; set; }

        /// <summary>
        /// The CLIP model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.ClipZeroShotClassificationRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.ClipZeroShotClassificationRequestModel Model { get; set; }

        /// <summary>
        /// Content to classify: a string, `TextDoc`, `ImageDoc`, or list of up to 512 items. Images up to 8MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>> Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipZeroShotClassificationRequest" /> class.
        /// </summary>
        /// <param name="labels">
        /// Candidate labels: a list of up to 512 labels, or a dict of up to 8 groups with max 64 labels each.
        /// </param>
        /// <param name="model">
        /// The CLIP model to use.
        /// </param>
        /// <param name="input">
        /// Content to classify: a string, `TextDoc`, `ImageDoc`, or list of up to 512 items. Images up to 8MB.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClipZeroShotClassificationRequest(
            global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>> labels,
            global::Jina.ClipZeroShotClassificationRequestModel model,
            global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc, global::Jina.ImageDoc>>> input)
        {
            this.Labels = labels;
            this.Model = model;
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipZeroShotClassificationRequest" /> class.
        /// </summary>
        public ClipZeroShotClassificationRequest()
        {
        }
    }
}