
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeEmbeddings1500MRequestEmbeddingType
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
    public static class CodeEmbeddings1500MRequestEmbeddingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeEmbeddings1500MRequestEmbeddingType value)
        {
            return value switch
            {
                CodeEmbeddings1500MRequestEmbeddingType.Float => "float",
                CodeEmbeddings1500MRequestEmbeddingType.Base64 => "base64",
                CodeEmbeddings1500MRequestEmbeddingType.Binary => "binary",
                CodeEmbeddings1500MRequestEmbeddingType.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeEmbeddings1500MRequestEmbeddingType? ToEnum(string value)
        {
            return value switch
            {
                "float" => CodeEmbeddings1500MRequestEmbeddingType.Float,
                "base64" => CodeEmbeddings1500MRequestEmbeddingType.Base64,
                "binary" => CodeEmbeddings1500MRequestEmbeddingType.Binary,
                "ubinary" => CodeEmbeddings1500MRequestEmbeddingType.Ubinary,
                _ => null,
            };
        }
    }
}