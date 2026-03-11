#nullable enable

namespace Jina
{
    public partial interface IZeroFewShotClassificationClient
    {
        /// <summary>
        /// List Classifiers<br/>
        /// List all classifiers owned by the authenticated user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Jina.ClassifierSummary>> ListClassifiers2Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}