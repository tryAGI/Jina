
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingsV4RequestTask2
    {
        /// <summary>
        /// 
        /// </summary>
        TextMatching,
        /// <summary>
        /// 
        /// </summary>
        RetrievalQuery,
        /// <summary>
        /// 
        /// </summary>
        RetrievalPassage,
        /// <summary>
        /// 
        /// </summary>
        CodeQuery,
        /// <summary>
        /// 
        /// </summary>
        CodePassage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsV4RequestTask2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV4RequestTask2 value)
        {
            return value switch
            {
                EmbeddingsV4RequestTask2.TextMatching => "text-matching",
                EmbeddingsV4RequestTask2.RetrievalQuery => "retrieval.query",
                EmbeddingsV4RequestTask2.RetrievalPassage => "retrieval.passage",
                EmbeddingsV4RequestTask2.CodeQuery => "code.query",
                EmbeddingsV4RequestTask2.CodePassage => "code.passage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV4RequestTask2? ToEnum(string value)
        {
            return value switch
            {
                "text-matching" => EmbeddingsV4RequestTask2.TextMatching,
                "retrieval.query" => EmbeddingsV4RequestTask2.RetrievalQuery,
                "retrieval.passage" => EmbeddingsV4RequestTask2.RetrievalPassage,
                "code.query" => EmbeddingsV4RequestTask2.CodeQuery,
                "code.passage" => EmbeddingsV4RequestTask2.CodePassage,
                _ => null,
            };
        }
    }
}