#nullable enable

namespace Jina
{
    public partial interface IBatchEmbeddingsClient
    {
        /// <summary>
        /// Download batch job output<br/>
        /// Stream the output JSONL file for a completed batch job.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DownloadBatchJobOutputAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}