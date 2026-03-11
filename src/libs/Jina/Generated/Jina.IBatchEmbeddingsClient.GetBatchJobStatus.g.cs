#nullable enable

namespace Jina
{
    public partial interface IBatchEmbeddingsClient
    {
        /// <summary>
        /// Get batch job status<br/>
        /// Retrieve the status of a batch embedding job.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.BatchStatus> GetBatchJobStatusAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}