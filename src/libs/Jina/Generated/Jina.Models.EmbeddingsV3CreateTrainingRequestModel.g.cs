
#nullable enable

namespace Jina
{
    /// <summary>
    /// Text embedding model for zero-shot classification.
    /// </summary>
    public enum EmbeddingsV3CreateTrainingRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsV3CreateTrainingRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV3CreateTrainingRequestModel value)
        {
            return value switch
            {
                EmbeddingsV3CreateTrainingRequestModel.JinaEmbeddingsV3 => "jina-embeddings-v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV3CreateTrainingRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-embeddings-v3" => EmbeddingsV3CreateTrainingRequestModel.JinaEmbeddingsV3,
                _ => null,
            };
        }
    }
}