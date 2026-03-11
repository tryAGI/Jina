
#nullable enable

namespace Jina
{
    /// <summary>
    /// The multimodal reranking model to use.
    /// </summary>
    public enum RerankerM0RequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        JinaRerankerM0,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RerankerM0RequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RerankerM0RequestModel value)
        {
            return value switch
            {
                RerankerM0RequestModel.JinaRerankerM0 => "jina-reranker-m0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RerankerM0RequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-reranker-m0" => RerankerM0RequestModel.JinaRerankerM0,
                _ => null,
            };
        }
    }
}