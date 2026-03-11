
#nullable enable

namespace Jina
{
    /// <summary>
    /// The embedding model to use.
    /// </summary>
    public enum EmbeddingsV4RequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        JinaEmbeddingsV4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsV4RequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV4RequestModel value)
        {
            return value switch
            {
                EmbeddingsV4RequestModel.JinaEmbeddingsV4 => "jina-embeddings-v4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV4RequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-embeddings-v4" => EmbeddingsV4RequestModel.JinaEmbeddingsV4,
                _ => null,
            };
        }
    }
}