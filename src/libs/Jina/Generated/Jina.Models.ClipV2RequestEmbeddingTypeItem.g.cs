
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClipV2RequestEmbeddingTypeItem
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
    public static class ClipV2RequestEmbeddingTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipV2RequestEmbeddingTypeItem value)
        {
            return value switch
            {
                ClipV2RequestEmbeddingTypeItem.Float => "float",
                ClipV2RequestEmbeddingTypeItem.Base64 => "base64",
                ClipV2RequestEmbeddingTypeItem.Binary => "binary",
                ClipV2RequestEmbeddingTypeItem.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipV2RequestEmbeddingTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "float" => ClipV2RequestEmbeddingTypeItem.Float,
                "base64" => ClipV2RequestEmbeddingTypeItem.Base64,
                "binary" => ClipV2RequestEmbeddingTypeItem.Binary,
                "ubinary" => ClipV2RequestEmbeddingTypeItem.Ubinary,
                _ => null,
            };
        }
    }
}