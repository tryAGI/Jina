#nullable enable

namespace Jina
{
    public partial interface ISearchFoundationModelsClient
    {
        /// <summary>
        /// Chat Completions (Experimental)<br/>
        /// **Experimental** - This endpoint is for testing purposes only. We do not guarantee its availability, scalability, or production-readiness. It may be removed or changed without notice.<br/>
        /// Generate a chat completion using jina-vlm (Vision Language Model). Supports text-only and multimodal (text + image) inputs in OpenAI-compatible format.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ChatCompletionsExperimentalAsync(
            global::Jina.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}