#nullable enable

namespace Jina
{
    public partial interface IHealthCheckClient
    {
        /// <summary>
        /// Ready<br/>
        /// Readiness probe for Kubernetes/Cloud Run.<br/>
        /// Checks if the service is ready to accept traffic by verifying:<br/>
        /// - Redis connectivity (if redis_client is provided)<br/>
        /// Returns:<br/>
        ///     200 with status details if ready<br/>
        ///     503 with failure details if not ready
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ReadyAsync(
            global::Jina.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}