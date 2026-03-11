
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingsV5RequestEmbeddingTypeItem
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
    public static class EmbeddingsV5RequestEmbeddingTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV5RequestEmbeddingTypeItem value)
        {
            return value switch
            {
                EmbeddingsV5RequestEmbeddingTypeItem.Float => "float",
                EmbeddingsV5RequestEmbeddingTypeItem.Base64 => "base64",
                EmbeddingsV5RequestEmbeddingTypeItem.Binary => "binary",
                EmbeddingsV5RequestEmbeddingTypeItem.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV5RequestEmbeddingTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "float" => EmbeddingsV5RequestEmbeddingTypeItem.Float,
                "base64" => EmbeddingsV5RequestEmbeddingTypeItem.Base64,
                "binary" => EmbeddingsV5RequestEmbeddingTypeItem.Binary,
                "ubinary" => EmbeddingsV5RequestEmbeddingTypeItem.Ubinary,
                _ => null,
            };
        }
    }
}