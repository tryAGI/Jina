
#nullable enable

namespace Jina
{
    /// <summary>
    /// Text embedding model for zero-shot classification.
    /// </summary>
    public enum EmbeddingsV5CreateTrainingRequestModel
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
    public static class EmbeddingsV5CreateTrainingRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV5CreateTrainingRequestModel value)
        {
            return value switch
            {
                EmbeddingsV5CreateTrainingRequestModel.JinaEmbeddingsV5TextNano => "jina-embeddings-v5-text-nano",
                EmbeddingsV5CreateTrainingRequestModel.JinaEmbeddingsV5TextSmall => "jina-embeddings-v5-text-small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV5CreateTrainingRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-embeddings-v5-text-nano" => EmbeddingsV5CreateTrainingRequestModel.JinaEmbeddingsV5TextNano,
                "jina-embeddings-v5-text-small" => EmbeddingsV5CreateTrainingRequestModel.JinaEmbeddingsV5TextSmall,
                _ => null,
            };
        }
    }
}