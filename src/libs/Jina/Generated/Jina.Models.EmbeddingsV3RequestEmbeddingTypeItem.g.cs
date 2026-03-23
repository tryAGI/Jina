
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingsV3RequestEmbeddingTypeItem
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
    public static class EmbeddingsV3RequestEmbeddingTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV3RequestEmbeddingTypeItem value)
        {
            return value switch
            {
                EmbeddingsV3RequestEmbeddingTypeItem.Base64 => "base64",
                EmbeddingsV3RequestEmbeddingTypeItem.Binary => "binary",
                EmbeddingsV3RequestEmbeddingTypeItem.Float => "float",
                EmbeddingsV3RequestEmbeddingTypeItem.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV3RequestEmbeddingTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "base64" => EmbeddingsV3RequestEmbeddingTypeItem.Base64,
                "binary" => EmbeddingsV3RequestEmbeddingTypeItem.Binary,
                "float" => EmbeddingsV3RequestEmbeddingTypeItem.Float,
                "ubinary" => EmbeddingsV3RequestEmbeddingTypeItem.Ubinary,
                _ => null,
            };
        }
    }
}