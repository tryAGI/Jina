
#nullable enable

namespace Jina
{
    /// <summary>
    /// The embedding model to use.
    /// </summary>
    public enum EmbeddingsV3RequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsV3RequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV3RequestModel value)
        {
            return value switch
            {
                EmbeddingsV3RequestModel.JinaEmbeddingsV3 => "jina-embeddings-v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV3RequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-embeddings-v3" => EmbeddingsV3RequestModel.JinaEmbeddingsV3,
                _ => null,
            };
        }
    }
}