
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum ColbertV2RequestEmbeddingType
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
    public static class ColbertV2RequestEmbeddingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColbertV2RequestEmbeddingType value)
        {
            return value switch
            {
                ColbertV2RequestEmbeddingType.Base64 => "base64",
                ColbertV2RequestEmbeddingType.Binary => "binary",
                ColbertV2RequestEmbeddingType.Float => "float",
                ColbertV2RequestEmbeddingType.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColbertV2RequestEmbeddingType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => ColbertV2RequestEmbeddingType.Base64,
                "binary" => ColbertV2RequestEmbeddingType.Binary,
                "float" => ColbertV2RequestEmbeddingType.Float,
                "ubinary" => ColbertV2RequestEmbeddingType.Ubinary,
                _ => null,
            };
        }
    }
}