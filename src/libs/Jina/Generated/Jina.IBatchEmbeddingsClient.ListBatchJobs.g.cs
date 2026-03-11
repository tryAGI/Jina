#nullable enable

namespace Jina
{
    public partial interface IBatchEmbeddingsClient
    {
        /// <summary>
        /// List batch jobs<br/>
        /// List recent batch jobs for the authenticated user.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Jina.BatchStatus>> ListBatchJobsAsync(
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}