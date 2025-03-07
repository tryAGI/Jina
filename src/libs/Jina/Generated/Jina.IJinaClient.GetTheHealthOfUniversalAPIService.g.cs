#nullable enable

namespace Jina
{
    public partial interface IJinaClient
    {
        /// <summary>
        /// Get the health of Universal API service<br/>
        /// Get the health of this Gateway service.<br/>
        /// .. # noqa: DAR201
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetTheHealthOfUniversalAPIServiceAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}