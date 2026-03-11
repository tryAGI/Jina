
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingsV4RequestEmbeddingTypeItem
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
    public static class EmbeddingsV4RequestEmbeddingTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV4RequestEmbeddingTypeItem value)
        {
            return value switch
            {
                EmbeddingsV4RequestEmbeddingTypeItem.Float => "float",
                EmbeddingsV4RequestEmbeddingTypeItem.Base64 => "base64",
                EmbeddingsV4RequestEmbeddingTypeItem.Binary => "binary",
                EmbeddingsV4RequestEmbeddingTypeItem.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV4RequestEmbeddingTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "float" => EmbeddingsV4RequestEmbeddingTypeItem.Float,
                "base64" => EmbeddingsV4RequestEmbeddingTypeItem.Base64,
                "binary" => EmbeddingsV4RequestEmbeddingTypeItem.Binary,
                "ubinary" => EmbeddingsV4RequestEmbeddingTypeItem.Ubinary,
                _ => null,
            };
        }
    }
}