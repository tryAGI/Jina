#nullable enable

namespace Jina
{
    public partial interface IZeroFewShotClassificationClient
    {
        /// <summary>
        /// Train<br/>
        /// Train or update a few-shot classifier.<br/>
        /// Create a new classifier with labeled examples, or update an existing one<br/>
        /// with additional training data.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.TrainingResponse> TrainAsync(

            global::Jina.AnyOf<global::Jina.TrainV1TrainPostRequestVariant1?, global::Jina.UpdateTrainingRequest> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Train<br/>
        /// Train or update a few-shot classifier.<br/>
        /// Create a new classifier with labeled examples, or update an existing one<br/>
        /// with additional training data.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.TrainingResponse> TrainAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}