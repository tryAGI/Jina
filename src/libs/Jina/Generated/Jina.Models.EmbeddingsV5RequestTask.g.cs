
#nullable enable

namespace Jina
{
    /// <summary>
    ///
    /// </summary>
    public enum EmbeddingsV5RequestTask
    {
        /// <summary>
        ///
        /// </summary>
        Classification,
        /// <summary>
        ///
        /// </summary>
        Clustering,
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
    public static class EmbeddingsV5RequestTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV5RequestTask value)
        {
            return value switch
            {
                EmbeddingsV5RequestTask.Classification => "classification",
                EmbeddingsV5RequestTask.Clustering => "clustering",
                EmbeddingsV5RequestTask.RetrievalPassage => "retrieval.passage",
                EmbeddingsV5RequestTask.RetrievalQuery => "retrieval.query",
                EmbeddingsV5RequestTask.TextMatching => "text-matching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV5RequestTask? ToEnum(string value)
        {
            return value switch
            {
                "classification" => EmbeddingsV5RequestTask.Classification,
                "clustering" => EmbeddingsV5RequestTask.Clustering,
                "retrieval.passage" => EmbeddingsV5RequestTask.RetrievalPassage,
                "retrieval.query" => EmbeddingsV5RequestTask.RetrievalQuery,
                "text-matching" => EmbeddingsV5RequestTask.TextMatching,
                _ => null,
            };
        }
    }
}