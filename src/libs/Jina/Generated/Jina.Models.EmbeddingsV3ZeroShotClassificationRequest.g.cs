
#nullable enable

namespace Jina
{
    /// <summary>
    /// Zero-shot classification using Embeddings v3.<br/>
    /// Example: {"input":["Explain the theory of relativity in simple terms.","Design a database schema for an e-commerce platform."],"labels":["Technical explanation","Creative writing","Business solution"],"model":"jina-embeddings-v3"}
    /// </summary>
    public sealed partial class EmbeddingsV3ZeroShotClassificationRequest
    {
        /// <summary>
        /// Text to classify: a string, `TextDoc`, or list of up to 512 items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> Input { get; set; }

        /// <summary>
        /// Candidate labels: a list of up to 512 labels, or a dict of up to 8 groups with max 64 labels each.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>> Labels { get; set; }

        /// <summary>
        /// The embedding model to use.
        /// </summary>
        /// <default>"jina-embeddings-v3"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "jina-embeddings-v3";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsV3ZeroShotClassificationRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Text to classify: a string, `TextDoc`, or list of up to 512 items.
        /// </param>
        /// <param name="labels">
        /// Candidate labels: a list of up to 512 labels, or a dict of up to 8 groups with max 64 labels each.
        /// </param>
        /// <param name="model">
        /// The embedding model to use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsV3ZeroShotClassificationRequest(
            global::Jina.AnyOf<string, global::Jina.TextDoc, global::System.Collections.Generic.IList<global::Jina.AnyOf<string, global::Jina.TextDoc>>> input,
            global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>> labels,
            string model = "jina-embeddings-v3")
        {
            this.Input = input;
            this.Labels = labels;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsV3ZeroShotClassificationRequest" /> class.
        /// </summary>
        public EmbeddingsV3ZeroShotClassificationRequest()
        {
        }
    }
}