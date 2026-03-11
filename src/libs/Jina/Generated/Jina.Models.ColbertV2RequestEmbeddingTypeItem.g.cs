
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum ColbertV2RequestEmbeddingTypeItem
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
    public static class ColbertV2RequestEmbeddingTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColbertV2RequestEmbeddingTypeItem value)
        {
            return value switch
            {
                ColbertV2RequestEmbeddingTypeItem.Float => "float",
                ColbertV2RequestEmbeddingTypeItem.Base64 => "base64",
                ColbertV2RequestEmbeddingTypeItem.Binary => "binary",
                ColbertV2RequestEmbeddingTypeItem.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColbertV2RequestEmbeddingTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "float" => ColbertV2RequestEmbeddingTypeItem.Float,
                "base64" => ColbertV2RequestEmbeddingTypeItem.Base64,
                "binary" => ColbertV2RequestEmbeddingTypeItem.Binary,
                "ubinary" => ColbertV2RequestEmbeddingTypeItem.Ubinary,
                _ => null,
            };
        }
    }
}