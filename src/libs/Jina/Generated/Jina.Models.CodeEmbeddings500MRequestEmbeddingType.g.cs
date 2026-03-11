
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeEmbeddings500MRequestEmbeddingType
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
    public static class CodeEmbeddings500MRequestEmbeddingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeEmbeddings500MRequestEmbeddingType value)
        {
            return value switch
            {
                CodeEmbeddings500MRequestEmbeddingType.Float => "float",
                CodeEmbeddings500MRequestEmbeddingType.Base64 => "base64",
                CodeEmbeddings500MRequestEmbeddingType.Binary => "binary",
                CodeEmbeddings500MRequestEmbeddingType.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeEmbeddings500MRequestEmbeddingType? ToEnum(string value)
        {
            return value switch
            {
                "float" => CodeEmbeddings500MRequestEmbeddingType.Float,
                "base64" => CodeEmbeddings500MRequestEmbeddingType.Base64,
                "binary" => CodeEmbeddings500MRequestEmbeddingType.Binary,
                "ubinary" => CodeEmbeddings500MRequestEmbeddingType.Ubinary,
                _ => null,
            };
        }
    }
}