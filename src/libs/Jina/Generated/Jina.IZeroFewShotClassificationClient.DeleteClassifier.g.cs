#nullable enable

namespace Jina
{
    public partial interface IZeroFewShotClassificationClient
    {
        /// <summary>
        /// Delete Classifier<br/>
        /// Delete a classifier by ID.
        /// </summary>
        /// <param name="classifierId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteClassifierAsync(
            string classifierId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}