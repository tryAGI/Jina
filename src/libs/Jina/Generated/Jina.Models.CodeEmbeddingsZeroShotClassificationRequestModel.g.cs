
#nullable enable

namespace Jina
{
    /// <summary>
    /// The code embedding model to use.
    /// </summary>
    public enum CodeEmbeddingsZeroShotClassificationRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        JinaCodeEmbeddings05b,
        /// <summary>
        /// 
        /// </summary>
        JinaCodeEmbeddings15b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeEmbeddingsZeroShotClassificationRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeEmbeddingsZeroShotClassificationRequestModel value)
        {
            return value switch
            {
                CodeEmbeddingsZeroShotClassificationRequestModel.JinaCodeEmbeddings05b => "jina-code-embeddings-0.5b",
                CodeEmbeddingsZeroShotClassificationRequestModel.JinaCodeEmbeddings15b => "jina-code-embeddings-1.5b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeEmbeddingsZeroShotClassificationRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-code-embeddings-0.5b" => CodeEmbeddingsZeroShotClassificationRequestModel.JinaCodeEmbeddings05b,
                "jina-code-embeddings-1.5b" => CodeEmbeddingsZeroShotClassificationRequestModel.JinaCodeEmbeddings15b,
                _ => null,
            };
        }
    }
}