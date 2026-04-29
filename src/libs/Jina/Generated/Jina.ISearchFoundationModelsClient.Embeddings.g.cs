#nullable enable

namespace Jina
{
    public partial interface ISearchFoundationModelsClient
    {
        /// <summary>
        /// Embeddings<br/>
        /// Generate embeddings for text, images, or documents.<br/>
        /// World-class multimodal multilingual embeddings for semantic search,<br/>
        /// similarity matching, clustering, and classification tasks.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.EmbeddingResponse> EmbeddingsAsync(

            global::Jina.EmbeddingsV1EmbeddingsPostRequest request,
            global::Jina.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Embeddings<br/>
        /// Generate embeddings for text, images, or documents.<br/>
        /// World-class multimodal multilingual embeddings for semantic search,<br/>
        /// similarity matching, clustering, and classification tasks.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.EmbeddingResponse> EmbeddingsAsync(
            global::Jina.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}