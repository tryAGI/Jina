#nullable enable

namespace Jina
{
    public partial interface IClassificationClient
    {
        /// <summary>
        /// List Classifier<br/>
        /// List classifiers.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ListClassifierAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}