
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum ColbertV1RequestEmbeddingType
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
    public static class ColbertV1RequestEmbeddingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColbertV1RequestEmbeddingType value)
        {
            return value switch
            {
                ColbertV1RequestEmbeddingType.Float => "float",
                ColbertV1RequestEmbeddingType.Base64 => "base64",
                ColbertV1RequestEmbeddingType.Binary => "binary",
                ColbertV1RequestEmbeddingType.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColbertV1RequestEmbeddingType? ToEnum(string value)
        {
            return value switch
            {
                "float" => ColbertV1RequestEmbeddingType.Float,
                "base64" => ColbertV1RequestEmbeddingType.Base64,
                "binary" => ColbertV1RequestEmbeddingType.Binary,
                "ubinary" => ColbertV1RequestEmbeddingType.Ubinary,
                _ => null,
            };
        }
    }
}