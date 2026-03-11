
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingsV5RequestEmbeddingType
    {
        /// <summary>
        /// 
        /// </summary>
        Float,
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
        Ubinary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsV5RequestEmbeddingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV5RequestEmbeddingType value)
        {
            return value switch
            {
                EmbeddingsV5RequestEmbeddingType.Float => "float",
                EmbeddingsV5RequestEmbeddingType.Base64 => "base64",
                EmbeddingsV5RequestEmbeddingType.Binary => "binary",
                EmbeddingsV5RequestEmbeddingType.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV5RequestEmbeddingType? ToEnum(string value)
        {
            return value switch
            {
                "float" => EmbeddingsV5RequestEmbeddingType.Float,
                "base64" => EmbeddingsV5RequestEmbeddingType.Base64,
                "binary" => EmbeddingsV5RequestEmbeddingType.Binary,
                "ubinary" => EmbeddingsV5RequestEmbeddingType.Ubinary,
                _ => null,
            };
        }
    }
}