
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingsV3RequestEmbeddingType
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
    public static class EmbeddingsV3RequestEmbeddingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV3RequestEmbeddingType value)
        {
            return value switch
            {
                EmbeddingsV3RequestEmbeddingType.Base64 => "base64",
                EmbeddingsV3RequestEmbeddingType.Binary => "binary",
                EmbeddingsV3RequestEmbeddingType.Float => "float",
                EmbeddingsV3RequestEmbeddingType.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV3RequestEmbeddingType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => EmbeddingsV3RequestEmbeddingType.Base64,
                "binary" => EmbeddingsV3RequestEmbeddingType.Binary,
                "float" => EmbeddingsV3RequestEmbeddingType.Float,
                "ubinary" => EmbeddingsV3RequestEmbeddingType.Ubinary,
                _ => null,
            };
        }
    }
}