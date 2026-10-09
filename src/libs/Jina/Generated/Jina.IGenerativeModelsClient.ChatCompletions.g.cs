#nullable enable

namespace Jina
{
    public partial interface IGenerativeModelsClient
    {
        /// <summary>
        /// Chat Completions<br/>
        /// Transcribe a document image. Send the page as an `image_url` content part and the reply is its text; `response_format` with a `json_schema` constrains that to a schema instead.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ChatCompletionsAsync(

            global::Jina.ChatCompletionRequest request,
            global::Jina.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat Completions<br/>
        /// Transcribe a document image. Send the page as an `image_url` content part and the reply is its text; `response_format` with a `json_schema` constrains that to a schema instead.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.AutoSDKHttpResponse<string>> ChatCompletionsAsResponseAsync(

            global::Jina.ChatCompletionRequest request,
            global::Jina.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat Completions<br/>
        /// Transcribe a document image. Send the page as an `image_url` content part and the reply is its text; `response_format` with a `json_schema` constrains that to a schema instead.
        /// </summary>
        /// <param name="frequencyPenalty"></param>
        /// <param name="logitBias"></param>
        /// <param name="logprobs"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="messages"></param>
        /// <param name="model">
        /// The model to use.
        /// </param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ChatCompletionsAsync(
            global::System.Collections.Generic.IList<global::Jina.ChatMessage> messages,
            double? frequencyPenalty = default,
            global::System.Collections.Generic.Dictionary<string, double>? logitBias = default,
            bool? logprobs = default,
            int? maxCompletionTokens = default,
            string model = "jina-ocr-v1",
            double? presencePenalty = default,
            global::Jina.ResponseFormatVariant1? responseFormat = default,
            int? seed = default,
            global::Jina.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            bool? stream = default,
            global::Jina.StreamOptions? streamOptions = default,
            double? temperature = default,
            int? topLogprobs = default,
            double? topP = default,
            global::Jina.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}