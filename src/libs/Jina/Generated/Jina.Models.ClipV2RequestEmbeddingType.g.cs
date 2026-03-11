
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClipV2RequestEmbeddingType
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
    public static class ClipV2RequestEmbeddingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipV2RequestEmbeddingType value)
        {
            return value switch
            {
                ClipV2RequestEmbeddingType.Float => "float",
                ClipV2RequestEmbeddingType.Base64 => "base64",
                ClipV2RequestEmbeddingType.Binary => "binary",
                ClipV2RequestEmbeddingType.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipV2RequestEmbeddingType? ToEnum(string value)
        {
            return value switch
            {
                "float" => ClipV2RequestEmbeddingType.Float,
                "base64" => ClipV2RequestEmbeddingType.Base64,
                "binary" => ClipV2RequestEmbeddingType.Binary,
                "ubinary" => ClipV2RequestEmbeddingType.Ubinary,
                _ => null,
            };
        }
    }
}