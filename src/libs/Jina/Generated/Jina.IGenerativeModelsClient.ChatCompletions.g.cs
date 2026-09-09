#nullable enable

namespace Jina
{
    public partial interface IGenerativeModelsClient
    {
        /// <summary>
        /// Chat Completions<br/>
        /// OpenAI-compatible chat completions. Point any OpenAI client at `https://api.jina.ai/v1` and set `model`.<br/>
        /// Set `stream: true` for incremental server-sent events. Parameters outside the supported set are accepted and ignored rather than rejected, so an SDK-generated payload always works.
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
        /// OpenAI-compatible chat completions. Point any OpenAI client at `https://api.jina.ai/v1` and set `model`.<br/>
        /// Set `stream: true` for incremental server-sent events. Parameters outside the supported set are accepted and ignored rather than rejected, so an SDK-generated payload always works.
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
        /// OpenAI-compatible chat completions. Point any OpenAI client at `https://api.jina.ai/v1` and set `model`.<br/>
        /// Set `stream: true` for incremental server-sent events. Parameters outside the supported set are accepted and ignored rather than rejected, so an SDK-generated payload always works.
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
            global::Jina.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? stop = default,
            bool? stream = default,
            global::Jina.StreamOptions? streamOptions = default,
            double? temperature = default,
            int? topLogprobs = default,
            double? topP = default,
            global::Jina.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}