
#nullable enable

namespace Jina
{
    /// <summary>
    /// The code embedding model to use.
    /// </summary>
    public enum CodeEmbeddings500MRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        JinaCodeEmbeddings05b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeEmbeddings500MRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeEmbeddings500MRequestModel value)
        {
            return value switch
            {
                CodeEmbeddings500MRequestModel.JinaCodeEmbeddings05b => "jina-code-embeddings-0.5b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeEmbeddings500MRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-code-embeddings-0.5b" => CodeEmbeddings500MRequestModel.JinaCodeEmbeddings05b,
                _ => null,
            };
        }
    }
}