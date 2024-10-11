#nullable enable

namespace Jina
{
    public partial interface IJinaApi
    {
        /// <summary>
        /// Get the health of Universal API service<br/>
        /// Get the health of this Gateway service.<br/>
        /// .. # noqa: DAR201
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<object> GetTheHealthOfUniversalAPIServiceAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}