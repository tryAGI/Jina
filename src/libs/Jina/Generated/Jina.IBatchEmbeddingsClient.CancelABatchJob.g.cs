#nullable enable

namespace Jina
{
    public partial interface IBatchEmbeddingsClient
    {
        /// <summary>
        /// Cancel a batch job<br/>
        /// Cancel a pending or processing batch job.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.BatchStatus> CancelABatchJobAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}