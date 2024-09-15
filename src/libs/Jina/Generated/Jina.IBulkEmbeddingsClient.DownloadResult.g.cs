#nullable enable

namespace Jina
{
    public partial interface IBulkEmbeddingsClient
    {
        /// <summary>
        /// Download Result
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.DownloadResultResponse> DownloadResultAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}