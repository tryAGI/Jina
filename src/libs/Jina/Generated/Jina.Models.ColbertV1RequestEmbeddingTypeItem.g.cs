
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum ColbertV1RequestEmbeddingTypeItem
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
    public static class ColbertV1RequestEmbeddingTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColbertV1RequestEmbeddingTypeItem value)
        {
            return value switch
            {
                ColbertV1RequestEmbeddingTypeItem.Float => "float",
                ColbertV1RequestEmbeddingTypeItem.Base64 => "base64",
                ColbertV1RequestEmbeddingTypeItem.Binary => "binary",
                ColbertV1RequestEmbeddingTypeItem.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColbertV1RequestEmbeddingTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "float" => ColbertV1RequestEmbeddingTypeItem.Float,
                "base64" => ColbertV1RequestEmbeddingTypeItem.Base64,
                "binary" => ColbertV1RequestEmbeddingTypeItem.Binary,
                "ubinary" => ColbertV1RequestEmbeddingTypeItem.Ubinary,
                _ => null,
            };
        }
    }
}