
#nullable enable

namespace Jina
{
    /// <summary>
    /// Information about a single model.
    /// </summary>
    public sealed partial class ModelInfo
    {
        /// <summary>
        /// Unique model identifier (e.g., `jina-ai/jina-embeddings-v3`).<br/>
        /// Example: 50336949b5bd1f1ed97f3085d76258a1
        /// </summary>
        /// <example>50336949b5bd1f1ed97f3085d76258a1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// HuggingFace model ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hugging_face_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HuggingFaceId { get; set; }

        /// <summary>
        /// Human-readable model name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Unix timestamp when the model was released.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// Supported input types: `text`, `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> InputModalities { get; set; }

        /// <summary>
        /// Output types: `embeddings`, `text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> OutputModalities { get; set; }

        /// <summary>
        /// Quantization level, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Quantization { get; set; }

        /// <summary>
        /// Maximum context length in tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContextLength { get; set; }

        /// <summary>
        /// Maximum output dimensions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxOutputLength { get; set; }

        /// <summary>
        /// Pricing information for a model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.ModelPricing Pricing { get; set; }

        /// <summary>
        /// Supported sampling parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_sampling_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SupportedSamplingParameters { get; set; }

        /// <summary>
        /// Supported features.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_features")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SupportedFeatures { get; set; }

        /// <summary>
        /// Model description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Available datacenter locations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datacenters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Jina.ModelDatacenter> Datacenters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfo" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique model identifier (e.g., `jina-ai/jina-embeddings-v3`).<br/>
        /// Example: 50336949b5bd1f1ed97f3085d76258a1
        /// </param>
        /// <param name="huggingFaceId">
        /// HuggingFace model ID.
        /// </param>
        /// <param name="name">
        /// Human-readable model name.
        /// </param>
        /// <param name="created">
        /// Unix timestamp when the model was released.
        /// </param>
        /// <param name="inputModalities">
        /// Supported input types: `text`, `image`.
        /// </param>
        /// <param name="outputModalities">
        /// Output types: `embeddings`, `text`.
        /// </param>
        /// <param name="quantization">
        /// Quantization level, if any.
        /// </param>
        /// <param name="contextLength">
        /// Maximum context length in tokens.
        /// </param>
        /// <param name="maxOutputLength">
        /// Maximum output dimensions.
        /// </param>
        /// <param name="pricing">
        /// Pricing information for a model.
        /// </param>
        /// <param name="supportedSamplingParameters">
        /// Supported sampling parameters.
        /// </param>
        /// <param name="supportedFeatures">
        /// Supported features.
        /// </param>
        /// <param name="description">
        /// Model description.
        /// </param>
        /// <param name="datacenters">
        /// Available datacenter locations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelInfo(
            string id,
            string huggingFaceId,
            string name,
            global::System.DateTimeOffset created,
            global::System.Collections.Generic.IList<string> inputModalities,
            global::System.Collections.Generic.IList<string> outputModalities,
            string quantization,
            int contextLength,
            int maxOutputLength,
            global::Jina.ModelPricing pricing,
            global::System.Collections.Generic.IList<string> supportedSamplingParameters,
            global::System.Collections.Generic.IList<string> supportedFeatures,
            string description,
            global::System.Collections.Generic.IList<global::Jina.ModelDatacenter> datacenters)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.HuggingFaceId = huggingFaceId ?? throw new global::System.ArgumentNullException(nameof(huggingFaceId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Created = created;
            this.InputModalities = inputModalities ?? throw new global::System.ArgumentNullException(nameof(inputModalities));
            this.OutputModalities = outputModalities ?? throw new global::System.ArgumentNullException(nameof(outputModalities));
            this.Quantization = quantization ?? throw new global::System.ArgumentNullException(nameof(quantization));
            this.ContextLength = contextLength;
            this.MaxOutputLength = maxOutputLength;
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.SupportedSamplingParameters = supportedSamplingParameters ?? throw new global::System.ArgumentNullException(nameof(supportedSamplingParameters));
            this.SupportedFeatures = supportedFeatures ?? throw new global::System.ArgumentNullException(nameof(supportedFeatures));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Datacenters = datacenters ?? throw new global::System.ArgumentNullException(nameof(datacenters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfo" /> class.
        /// </summary>
        public ModelInfo()
        {
        }
    }
}