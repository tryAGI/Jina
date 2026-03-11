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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.EmbeddingResponse> EmbeddingsAsync(

            global::Jina.EmbeddingsV1EmbeddingsPostRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Embeddings<br/>
        /// Generate embeddings for text, images, or documents.<br/>
        /// World-class multimodal multilingual embeddings for semantic search,<br/>
        /// similarity matching, clustering, and classification tasks.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.EmbeddingResponse> EmbeddingsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}