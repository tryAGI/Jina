#nullable enable

namespace Jina
{
    public partial interface IZeroFewShotClassificationClient
    {
        /// <summary>
        /// Classify<br/>
        /// Classify text or images into categories.<br/>
        /// Zero-shot and few-shot classification. Zero-shot uses embedding similarity,<br/>
        /// few-shot uses a trained classifier.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.ClassificationResponse> ClassifyAsync(

            global::Jina.AnyOf<global::Jina.ClassifyV1ClassifyPostRequestVariant1?, global::Jina.FewShotClassificationRequest> request,
            global::Jina.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Classify<br/>
        /// Classify text or images into categories.<br/>
        /// Zero-shot and few-shot classification. Zero-shot uses embedding similarity,<br/>
        /// few-shot uses a trained classifier.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.ClassificationResponse> ClassifyAsync(
            global::Jina.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}