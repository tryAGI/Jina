#nullable enable

namespace Jina
{
    public partial interface IModelListClient
    {
        /// <summary>
        /// List Models<br/>
        /// List all available Jina AI models.<br/>
        /// Returns model metadata in OpenRouter-compatible format including<br/>
        /// model IDs, input/output modalities, context lengths, and pricing.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.ModelListResponse> ListModelsAsync(
            global::Jina.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Models<br/>
        /// List all available Jina AI models.<br/>
        /// Returns model metadata in OpenRouter-compatible format including<br/>
        /// model IDs, input/output modalities, context lengths, and pricing.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.AutoSDKHttpResponse<global::Jina.ModelListResponse>> ListModelsAsResponseAsync(
            global::Jina.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}