
#nullable enable

namespace Jina
{
    /// <summary>
    /// Multimodal embedding model for zero-shot classification.
    /// </summary>
    public enum EmbeddingsV4CreateTrainingRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsV4CreateTrainingRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV4CreateTrainingRequestModel value)
        {
            return value switch
            {
                EmbeddingsV4CreateTrainingRequestModel.JinaEmbeddingsV4 => "jina-embeddings-v4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV4CreateTrainingRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-embeddings-v4" => EmbeddingsV4CreateTrainingRequestModel.JinaEmbeddingsV4,
                _ => null,
            };
        }
    }
}