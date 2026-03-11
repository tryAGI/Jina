
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum ELSERV2RequestEmbeddingType
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
    public static class ELSERV2RequestEmbeddingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ELSERV2RequestEmbeddingType value)
        {
            return value switch
            {
                ELSERV2RequestEmbeddingType.Float => "float",
                ELSERV2RequestEmbeddingType.Base64 => "base64",
                ELSERV2RequestEmbeddingType.Binary => "binary",
                ELSERV2RequestEmbeddingType.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ELSERV2RequestEmbeddingType? ToEnum(string value)
        {
            return value switch
            {
                "float" => ELSERV2RequestEmbeddingType.Float,
                "base64" => ELSERV2RequestEmbeddingType.Base64,
                "binary" => ELSERV2RequestEmbeddingType.Binary,
                "ubinary" => ELSERV2RequestEmbeddingType.Ubinary,
                _ => null,
            };
        }
    }
}