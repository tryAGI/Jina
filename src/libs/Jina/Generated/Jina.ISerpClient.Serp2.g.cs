#nullable enable

namespace Jina
{
    public partial interface ISerpClient
    {
        /// <summary>
        /// Serp
        /// </summary>
        /// <param name="path"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> Serp2Async(
            string path,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}