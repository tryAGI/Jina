#nullable enable

namespace Jina
{
    public partial interface IModelListClient
    {
        /// <summary>
        /// Get Model<br/>
        /// One model by id, in full (`jina-ai/jina-embeddings-v3`) or short<br/>
        /// (`jina-embeddings-v3`) form.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.ModelInfo> GetModelAsync(
            string modelId,
            global::Jina.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Model<br/>
        /// One model by id, in full (`jina-ai/jina-embeddings-v3`) or short<br/>
        /// (`jina-embeddings-v3`) form.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.AutoSDKHttpResponse<global::Jina.ModelInfo>> GetModelAsResponseAsync(
            string modelId,
            global::Jina.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}