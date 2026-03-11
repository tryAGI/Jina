
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeEmbeddings1500MRequestEmbeddingTypeItem
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
    public static class CodeEmbeddings1500MRequestEmbeddingTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeEmbeddings1500MRequestEmbeddingTypeItem value)
        {
            return value switch
            {
                CodeEmbeddings1500MRequestEmbeddingTypeItem.Float => "float",
                CodeEmbeddings1500MRequestEmbeddingTypeItem.Base64 => "base64",
                CodeEmbeddings1500MRequestEmbeddingTypeItem.Binary => "binary",
                CodeEmbeddings1500MRequestEmbeddingTypeItem.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeEmbeddings1500MRequestEmbeddingTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "float" => CodeEmbeddings1500MRequestEmbeddingTypeItem.Float,
                "base64" => CodeEmbeddings1500MRequestEmbeddingTypeItem.Base64,
                "binary" => CodeEmbeddings1500MRequestEmbeddingTypeItem.Binary,
                "ubinary" => CodeEmbeddings1500MRequestEmbeddingTypeItem.Ubinary,
                _ => null,
            };
        }
    }
}