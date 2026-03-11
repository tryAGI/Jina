
#nullable enable

namespace Jina
{
    /// <summary>
    /// The reranking model to use.
    /// </summary>
    public enum RerankerV3RequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        JinaRerankerV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RerankerV3RequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RerankerV3RequestModel value)
        {
            return value switch
            {
                RerankerV3RequestModel.JinaRerankerV3 => "jina-reranker-v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RerankerV3RequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-reranker-v3" => RerankerV3RequestModel.JinaRerankerV3,
                _ => null,
            };
        }
    }
}