
#nullable enable

namespace Jina
{
    /// <summary>
    /// The public request body. Every field here reaches the engine.
    /// </summary>
    public sealed partial class ChatCompletionRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logit_bias")]
        public global::System.Collections.Generic.Dictionary<string, double>? LogitBias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public bool? Logprobs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Jina.ChatMessage> Messages { get; set; }

        /// <summary>
        /// The model to use.
        /// </summary>
        /// <default>"jina-ocr-v1"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "jina-ocr-v1";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::Jina.ResponseFormatVariant1? ResponseFormat { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>))]
        public global::Jina.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? Stop { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_options")]
        public global::Jina.StreamOptions? StreamOptions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="logitBias"></param>
        /// <param name="logprobs"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="responseFormat"></param>
        /// <param name="seed"></param>
        /// <param name="stop"></param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions"></param>
        /// <param name="temperature"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="topP"></param>
        /// <param name="model">
        /// The model to use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequest(
            global::System.Collections.Generic.IList<global::Jina.ChatMessage> messages,
            double? frequencyPenalty,
            global::System.Collections.Generic.Dictionary<string, double>? logitBias,
            bool? logprobs,
            int? maxCompletionTokens,
            double? presencePenalty,
            global::Jina.ResponseFormatVariant1? responseFormat,
            int? seed,
            global::Jina.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? stop,
            bool? stream,
            global::Jina.StreamOptions? streamOptions,
            double? temperature,
            int? topLogprobs,
            double? topP,
            string model = "jina-ocr-v1")
        {
            this.FrequencyPenalty = frequencyPenalty;
            this.LogitBias = logitBias;
            this.Logprobs = logprobs;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Model = model;
            this.PresencePenalty = presencePenalty;
            this.ResponseFormat = responseFormat;
            this.Seed = seed;
            this.Stop = stop;
            this.Stream = stream;
            this.StreamOptions = streamOptions;
            this.Temperature = temperature;
            this.TopLogprobs = topLogprobs;
            this.TopP = topP;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        public ChatCompletionRequest()
        {
        }

    }
}