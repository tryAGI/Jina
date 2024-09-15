#nullable enable

namespace Jina
{
    public partial interface IBulkEmbeddingsClient
    {
        /// <summary>
        /// Start Bulk Embedding<br/>
        /// Upload a file and get embeddings for each row
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.BulkEmbeddingJobResponse> StartBulkEmbeddingAsync(
            global::Jina.BodyStartBulkEmbeddingV1BulkEmbeddingsPost request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Start Bulk Embedding<br/>
        /// Upload a file and get embeddings for each row
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="email"></param>
        /// <param name="model"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.BulkEmbeddingJobResponse> StartBulkEmbeddingAsync(
            byte[] file,
            string filename,
            string model,
            string? email = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}