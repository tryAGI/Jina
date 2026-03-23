
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingsV4RequestEmbeddingType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
        /// <summary>
        /// 
        /// </summary>
        Binary,
        /// <summary>
        /// 
        /// </summary>
        Float,
        /// <summary>
        /// 
        /// </summary>
        Ubinary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsV4RequestEmbeddingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV4RequestEmbeddingType value)
        {
            return value switch
            {
                EmbeddingsV4RequestEmbeddingType.Base64 => "base64",
                EmbeddingsV4RequestEmbeddingType.Binary => "binary",
                EmbeddingsV4RequestEmbeddingType.Float => "float",
                EmbeddingsV4RequestEmbeddingType.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV4RequestEmbeddingType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => EmbeddingsV4RequestEmbeddingType.Base64,
                "binary" => EmbeddingsV4RequestEmbeddingType.Binary,
                "float" => EmbeddingsV4RequestEmbeddingType.Float,
                "ubinary" => EmbeddingsV4RequestEmbeddingType.Ubinary,
                _ => null,
            };
        }
    }
}