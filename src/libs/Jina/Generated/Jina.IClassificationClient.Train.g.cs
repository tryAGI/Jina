#nullable enable

namespace Jina
{
    public partial interface IClassificationClient
    {
        /// <summary>
        /// Train<br/>
        /// Rank pairs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.TrainingOutput> TrainAsync(
            global::Jina.TrainingAPIInput request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Train<br/>
        /// Rank pairs.
        /// </summary>
        /// <param name="model">
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-clip-v1`,	223M,	768<br/>
        /// - `jina-embeddings-v2-base-en`,	137M,	768<br/>
        /// - `jina-embeddings-v2-base-es`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-de`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-zh`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-code`,	137M,	768<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2307.11224).<br/>
        /// You can provide only either `model` or `classifier_id`
        /// </param>
        /// <param name="classifierId">
        /// The identifier of the classifier. If not provided, a new classifier will be created.<br/>
        /// You can provide only either `model` or `classifier_id`
        /// </param>
        /// <param name="access">
        /// The accessibility of the classifier when created. Will be ignored if `classifier_id` is provided<br/>
        /// Default Value: private
        /// </param>
        /// <param name="input">
        /// List of text and images and labels or a single text and image and label to train the classifier
        /// </param>
        /// <param name="numIters">
        /// The number of iterations to train the classifier<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.TrainingOutput> TrainAsync(
            global::Jina.AnyOf<global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextExampleDoc, global::Jina.ImageExampleDoc>>, global::Jina.TextExampleDoc, global::Jina.ImageExampleDoc> input,
            string? model = default,
            string? classifierId = default,
            global::Jina.TrainingAPIInputAccess? access = default,
            int? numIters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}