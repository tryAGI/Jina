
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Jina
{
    /// <summary>
    /// Zero-shot classification using code embedding models.<br/>
    /// Example: {"input":["def hello_world():\n    print(\u0027Hello, World!\u0027)","SELECT * FROM users WHERE id = 1;"],"labels":["Python","JavaScript","SQL","Rust"],"model":"jina-code-embeddings-0.5b"}
    /// </summary>
    public sealed partial class CodeEmbeddingsZeroShotClassificationRequest
    {
        /// <summary>
        /// Candidate labels: a list of up to 512 labels, or a dict of up to 8 groups with max 64 labels each.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>> Labels { get; set; }

        /// <summary>
        /// The code embedding model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.CodeEmbeddingsZeroShotClassificationRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.CodeEmbeddingsZeroShotClassificationRequestModel Model { get; set; }

        /// <summary>
        /// Code to classify: a string, `TextDoc`, or list of up to 512 items.
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
        /// Initializes a new instance of the <see cref="CodeEmbeddingsZeroShotClassificationRequest" /> class.
        /// </summary>
        /// <param name="labels">
        /// Candidate labels: a list of up to 512 labels, or a dict of up to 8 groups with max 64 labels each.
        /// </param>
        /// <param name="model">
        /// The code embedding model to use.
        /// </param>
        /// <param name="input">
        /// Code to classify: a string, `TextDoc`, or list of up to 512 items.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeEmbeddingsZeroShotClassificationRequest(
            global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>> labels,
            global::Jina.CodeEmbeddingsZeroShotClassificationRequestModel model,
            global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> input)
        {
            this.Labels = labels;
            this.Model = model;
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeEmbeddingsZeroShotClassificationRequest" /> class.
        /// </summary>
        public CodeEmbeddingsZeroShotClassificationRequest()
        {
        }
    }
}