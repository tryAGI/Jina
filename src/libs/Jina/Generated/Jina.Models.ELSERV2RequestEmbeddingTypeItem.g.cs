
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum ELSERV2RequestEmbeddingTypeItem
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
    public static class ELSERV2RequestEmbeddingTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ELSERV2RequestEmbeddingTypeItem value)
        {
            return value switch
            {
                ELSERV2RequestEmbeddingTypeItem.Float => "float",
                ELSERV2RequestEmbeddingTypeItem.Base64 => "base64",
                ELSERV2RequestEmbeddingTypeItem.Binary => "binary",
                ELSERV2RequestEmbeddingTypeItem.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ELSERV2RequestEmbeddingTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "float" => ELSERV2RequestEmbeddingTypeItem.Float,
                "base64" => ELSERV2RequestEmbeddingTypeItem.Base64,
                "binary" => ELSERV2RequestEmbeddingTypeItem.Binary,
                "ubinary" => ELSERV2RequestEmbeddingTypeItem.Ubinary,
                _ => null,
            };
        }
    }
}