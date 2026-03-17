#nullable enable

namespace Jina
{
    public partial interface IBatchEmbeddingsClient
    {
        /// <summary>
        /// Create a batch embedding job<br/>
        /// Submit a batch of texts for asynchronous embedding processing.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.BatchStatus> CreateABatchEmbeddingJobAsync(

            global::Jina.BatchEmbeddingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a batch embedding job<br/>
        /// Submit a batch of texts for asynchronous embedding processing.
        /// </summary>
        /// <param name="dimensions">
        /// Number of dimensions for output embeddings (1-1024).
        /// </param>
        /// <param name="input">
        /// Inline JSONL lines for small batches. Either input_url or input must be provided.
        /// </param>
        /// <param name="inputUrl">
        /// URL to input JSONL file (GCS, S3, or HTTP). Either input_url or input must be provided.
        /// </param>
        /// <param name="model">
        /// The embedding model to use for batch processing.
        /// </param>
        /// <param name="normalized">
        /// If true (default), embeddings are L2-normalized to unit length.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="task">
        /// Task optimization: retrieval, text-matching, clustering, or classification.<br/>
        /// Default Value: text-matching
        /// </param>
        /// <param name="webhookUrl">
        /// URL to POST notification when job completes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.BatchStatus> CreateABatchEmbeddingJobAsync(
            global::Jina.BatchEmbeddingRequestModel model,
            int? dimensions = default,
            global::System.Collections.Generic.IList<object>? input = default,
            string? inputUrl = default,
            bool? normalized = default,
            string? task = default,
            string? webhookUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}