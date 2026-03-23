
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingsV2RequestEmbeddingTypeItem
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
    public static class EmbeddingsV2RequestEmbeddingTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV2RequestEmbeddingTypeItem value)
        {
            return value switch
            {
                EmbeddingsV2RequestEmbeddingTypeItem.Base64 => "base64",
                EmbeddingsV2RequestEmbeddingTypeItem.Binary => "binary",
                EmbeddingsV2RequestEmbeddingTypeItem.Float => "float",
                EmbeddingsV2RequestEmbeddingTypeItem.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV2RequestEmbeddingTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "base64" => EmbeddingsV2RequestEmbeddingTypeItem.Base64,
                "binary" => EmbeddingsV2RequestEmbeddingTypeItem.Binary,
                "float" => EmbeddingsV2RequestEmbeddingTypeItem.Float,
                "ubinary" => EmbeddingsV2RequestEmbeddingTypeItem.Ubinary,
                _ => null,
            };
        }
    }
}