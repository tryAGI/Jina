
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClipV1RequestEmbeddingTypeItem
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
    public static class ClipV1RequestEmbeddingTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipV1RequestEmbeddingTypeItem value)
        {
            return value switch
            {
                ClipV1RequestEmbeddingTypeItem.Base64 => "base64",
                ClipV1RequestEmbeddingTypeItem.Binary => "binary",
                ClipV1RequestEmbeddingTypeItem.Float => "float",
                ClipV1RequestEmbeddingTypeItem.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipV1RequestEmbeddingTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "base64" => ClipV1RequestEmbeddingTypeItem.Base64,
                "binary" => ClipV1RequestEmbeddingTypeItem.Binary,
                "float" => ClipV1RequestEmbeddingTypeItem.Float,
                "ubinary" => ClipV1RequestEmbeddingTypeItem.Ubinary,
                _ => null,
            };
        }
    }
}