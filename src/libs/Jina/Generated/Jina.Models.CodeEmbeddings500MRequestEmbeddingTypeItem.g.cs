
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeEmbeddings500MRequestEmbeddingTypeItem
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
    public static class CodeEmbeddings500MRequestEmbeddingTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeEmbeddings500MRequestEmbeddingTypeItem value)
        {
            return value switch
            {
                CodeEmbeddings500MRequestEmbeddingTypeItem.Float => "float",
                CodeEmbeddings500MRequestEmbeddingTypeItem.Base64 => "base64",
                CodeEmbeddings500MRequestEmbeddingTypeItem.Binary => "binary",
                CodeEmbeddings500MRequestEmbeddingTypeItem.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeEmbeddings500MRequestEmbeddingTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "float" => CodeEmbeddings500MRequestEmbeddingTypeItem.Float,
                "base64" => CodeEmbeddings500MRequestEmbeddingTypeItem.Base64,
                "binary" => CodeEmbeddings500MRequestEmbeddingTypeItem.Binary,
                "ubinary" => CodeEmbeddings500MRequestEmbeddingTypeItem.Ubinary,
                _ => null,
            };
        }
    }
}