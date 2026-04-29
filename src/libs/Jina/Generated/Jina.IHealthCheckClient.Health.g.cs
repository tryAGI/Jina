#nullable enable

namespace Jina
{
    public partial interface IHealthCheckClient
    {
        /// <summary>
        /// Health<br/>
        /// Basic health check endpoint.<br/>
        /// Returns 200 if the service is running. This is the simplest health check<br/>
        /// that only verifies the process is alive and can handle HTTP requests.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthAsync(
            global::Jina.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}