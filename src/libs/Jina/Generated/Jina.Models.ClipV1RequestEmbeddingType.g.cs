
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClipV1RequestEmbeddingType
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
    public static class ClipV1RequestEmbeddingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipV1RequestEmbeddingType value)
        {
            return value switch
            {
                ClipV1RequestEmbeddingType.Float => "float",
                ClipV1RequestEmbeddingType.Base64 => "base64",
                ClipV1RequestEmbeddingType.Binary => "binary",
                ClipV1RequestEmbeddingType.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipV1RequestEmbeddingType? ToEnum(string value)
        {
            return value switch
            {
                "float" => ClipV1RequestEmbeddingType.Float,
                "base64" => ClipV1RequestEmbeddingType.Base64,
                "binary" => ClipV1RequestEmbeddingType.Binary,
                "ubinary" => ClipV1RequestEmbeddingType.Ubinary,
                _ => null,
            };
        }
    }
}