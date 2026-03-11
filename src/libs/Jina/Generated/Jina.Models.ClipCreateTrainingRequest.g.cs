
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// Example: {"access":"public","input":[{"image":"https://images.unsplash.com/photo-1518717758536-85ae29035b6d","label":"Cat"},{"label":"Art","text":"A painting of a sunset over the mountains."}],"model":"jina-clip-v2","num_iters":12}
    /// </summary>
    public sealed partial class ClipCreateTrainingRequest
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
        /// CLIP model for zero-shot classification of images and text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.ClipCreateTrainingRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.ClipCreateTrainingRequestModel Model { get; set; }

        /// <summary>
        /// Must be a list of text-label or image-label training items with at least two unique labels. For batch training, provide a list with up to 512 items. Each image can be up to 8MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>> Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipCreateTrainingRequest" /> class.
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
        /// CLIP model for zero-shot classification of images and text.
        /// </param>
        /// <param name="input">
        /// Must be a list of text-label or image-label training items with at least two unique labels. For batch training, provide a list with up to 512 items. Each image can be up to 8MB.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClipCreateTrainingRequest(
            global::Jina.ClipCreateTrainingRequestModel model,
            global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextTrainingItem, global::Jina.ImageTrainingItem>> input,
            string? access,
            int? numIters)
        {
            this.Model = model;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Access = access;
            this.NumIters = numIters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipCreateTrainingRequest" /> class.
        /// </summary>
        public ClipCreateTrainingRequest()
        {
        }
    }
}