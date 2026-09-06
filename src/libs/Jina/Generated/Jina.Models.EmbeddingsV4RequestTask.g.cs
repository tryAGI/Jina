
#nullable enable

namespace Jina
{
    /// <summary>
    ///
    /// </summary>
    public enum EmbeddingsV4RequestTask
    {
        /// <summary>
        ///
        /// </summary>
        CodePassage,
        /// <summary>
        ///
        /// </summary>
        CodeQuery,
        /// <summary>
        ///
        /// </summary>
        RetrievalPassage,
        /// <summary>
        ///
        /// </summary>
        RetrievalQuery,
        /// <summary>
        ///
        /// </summary>
        TextMatching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsV4RequestTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV4RequestTask value)
        {
            return value switch
            {
                EmbeddingsV4RequestTask.CodePassage => "code.passage",
                EmbeddingsV4RequestTask.CodeQuery => "code.query",
                EmbeddingsV4RequestTask.RetrievalPassage => "retrieval.passage",
                EmbeddingsV4RequestTask.RetrievalQuery => "retrieval.query",
                EmbeddingsV4RequestTask.TextMatching => "text-matching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV4RequestTask? ToEnum(string value)
        {
            return value switch
            {
                "code.passage" => EmbeddingsV4RequestTask.CodePassage,
                "code.query" => EmbeddingsV4RequestTask.CodeQuery,
                "retrieval.passage" => EmbeddingsV4RequestTask.RetrievalPassage,
                "retrieval.query" => EmbeddingsV4RequestTask.RetrievalQuery,
                "text-matching" => EmbeddingsV4RequestTask.TextMatching,
                _ => null,
            };
        }
    }
}