#nullable enable

namespace Jina
{
    public partial interface IClassificationClient
    {
        /// <summary>
        /// Delete Classifier<br/>
        /// List classifiers.
        /// </summary>
        /// <param name="classifierId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteClassifierAsync(
            string classifierId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}