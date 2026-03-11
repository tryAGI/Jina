
#nullable enable

namespace Jina
{
    /// <summary>
    /// The code embedding model to use.
    /// </summary>
    public enum CodeEmbeddings1500MRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        JinaCodeEmbeddings15b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeEmbeddings1500MRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeEmbeddings1500MRequestModel value)
        {
            return value switch
            {
                CodeEmbeddings1500MRequestModel.JinaCodeEmbeddings15b => "jina-code-embeddings-1.5b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeEmbeddings1500MRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-code-embeddings-1.5b" => CodeEmbeddings1500MRequestModel.JinaCodeEmbeddings15b,
                _ => null,
            };
        }
    }
}