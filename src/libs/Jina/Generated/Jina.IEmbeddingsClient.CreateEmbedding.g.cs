#nullable enable

namespace Jina
{
    public partial interface IEmbeddingsClient
    {
        /// <summary>
        /// Create Embedding<br/>
        /// Create embedding representations of the given input texts.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.ModelEmbeddingOutput> CreateEmbeddingAsync(
            global::Jina.EmbeddingInput request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Embedding<br/>
        /// Create embedding representations of the given input texts.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.ModelEmbeddingOutput> CreateEmbeddingAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}