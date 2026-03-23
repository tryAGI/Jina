
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingsV2RequestEmbeddingType
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
    public static class EmbeddingsV2RequestEmbeddingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV2RequestEmbeddingType value)
        {
            return value switch
            {
                EmbeddingsV2RequestEmbeddingType.Base64 => "base64",
                EmbeddingsV2RequestEmbeddingType.Binary => "binary",
                EmbeddingsV2RequestEmbeddingType.Float => "float",
                EmbeddingsV2RequestEmbeddingType.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV2RequestEmbeddingType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => EmbeddingsV2RequestEmbeddingType.Base64,
                "binary" => EmbeddingsV2RequestEmbeddingType.Binary,
                "float" => EmbeddingsV2RequestEmbeddingType.Float,
                "ubinary" => EmbeddingsV2RequestEmbeddingType.Ubinary,
                _ => null,
            };
        }
    }
}