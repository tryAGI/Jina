#nullable enable

namespace Jina
{
    public partial interface ISearchFoundationModelsClient
    {
        /// <summary>
        /// Rerank<br/>
        /// Rerank documents by relevance to a query.<br/>
        /// World-class reranker for maximizing search relevancy and RAG accuracy.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.RerankingResponse> RerankAsync(

            global::Jina.RerankV1RerankPostRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rerank<br/>
        /// Rerank documents by relevance to a query.<br/>
        /// World-class reranker for maximizing search relevancy and RAG accuracy.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.RerankingResponse> RerankAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}