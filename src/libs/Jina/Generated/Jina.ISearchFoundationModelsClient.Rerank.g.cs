#nullable enable

namespace Jina
{
    public partial interface ISearchFoundationModelsClient
    {
        /// <summary>
        /// Rerank<br/>
        /// Score documents against a query and return them reordered.<br/>
        /// Results come back sorted by `relevance_score`, each carrying the index<br/>
        /// it held in the request so the caller can map them back.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.RerankingResponse> RerankAsync(

            global::Jina.RerankV1RerankPostRequest request,
            global::Jina.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rerank<br/>
        /// Score documents against a query and return them reordered.<br/>
        /// Results come back sorted by `relevance_score`, each carrying the index<br/>
        /// it held in the request so the caller can map them back.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.AutoSDKHttpResponse<global::Jina.RerankingResponse>> RerankAsResponseAsync(

            global::Jina.RerankV1RerankPostRequest request,
            global::Jina.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rerank<br/>
        /// Score documents against a query and return them reordered.<br/>
        /// Results come back sorted by `relevance_score`, each carrying the index<br/>
        /// it held in the request so the caller can map them back.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.RerankingResponse> RerankAsync(
            global::Jina.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}