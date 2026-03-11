
#nullable enable

namespace Jina
{
    /// <summary>
    /// Task optimization: `text-matching` (default), `retrieval.query`, `retrieval.passage`, `code.query`, or `code.passage`.<br/>
    /// Default Value: text-matching
    /// </summary>
    public enum EmbeddingsV4RequestTask
    {
        /// <summary>
        /// `text-matching` (default), `retrieval.query`, `retrieval.passage`, `code.query`, or `code.passage`.
        /// </summary>
        TextMatching,
        /// <summary>
        /// `text-matching` (default), `retrieval.query`, `retrieval.passage`, `code.query`, or `code.passage`.
        /// </summary>
        RetrievalQuery,
        /// <summary>
        /// `text-matching` (default), `retrieval.query`, `retrieval.passage`, `code.query`, or `code.passage`.
        /// </summary>
        RetrievalPassage,
        /// <summary>
        /// `text-matching` (default), `retrieval.query`, `retrieval.passage`, `code.query`, or `code.passage`.
        /// </summary>
        CodeQuery,
        /// <summary>
        /// `text-matching` (default), `retrieval.query`, `retrieval.passage`, `code.query`, or `code.passage`.
        /// </summary>
        CodePassage,
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
                EmbeddingsV4RequestTask.TextMatching => "text-matching",
                EmbeddingsV4RequestTask.RetrievalQuery => "retrieval.query",
                EmbeddingsV4RequestTask.RetrievalPassage => "retrieval.passage",
                EmbeddingsV4RequestTask.CodeQuery => "code.query",
                EmbeddingsV4RequestTask.CodePassage => "code.passage",
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
                "text-matching" => EmbeddingsV4RequestTask.TextMatching,
                "retrieval.query" => EmbeddingsV4RequestTask.RetrievalQuery,
                "retrieval.passage" => EmbeddingsV4RequestTask.RetrievalPassage,
                "code.query" => EmbeddingsV4RequestTask.CodeQuery,
                "code.passage" => EmbeddingsV4RequestTask.CodePassage,
                _ => null,
            };
        }
    }
}