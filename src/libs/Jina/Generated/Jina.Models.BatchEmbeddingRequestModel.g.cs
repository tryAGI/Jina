
#nullable enable

namespace Jina
{
    /// <summary>
    /// The embedding model to use for batch processing.
    /// </summary>
    public enum BatchEmbeddingRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV5TextNano,
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV5TextSmall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchEmbeddingRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchEmbeddingRequestModel value)
        {
            return value switch
            {
                BatchEmbeddingRequestModel.JinaEmbeddingsV5TextNano => "jina-embeddings-v5-text-nano",
                BatchEmbeddingRequestModel.JinaEmbeddingsV5TextSmall => "jina-embeddings-v5-text-small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchEmbeddingRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-embeddings-v5-text-nano" => BatchEmbeddingRequestModel.JinaEmbeddingsV5TextNano,
                "jina-embeddings-v5-text-small" => BatchEmbeddingRequestModel.JinaEmbeddingsV5TextSmall,
                _ => null,
            };
        }
    }
}