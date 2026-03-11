#nullable enable

namespace Jina
{
    public partial interface IHealthCheckClient
    {
        /// <summary>
        /// Live<br/>
        /// Liveness probe for Kubernetes/Cloud Run.<br/>
        /// Lightweight check that the process is responsive. Unlike readiness,<br/>
        /// this should not check external dependencies - it only verifies that<br/>
        /// the event loop is not blocked and can handle requests.<br/>
        /// A failed liveness probe typically results in container restart.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> LiveAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}