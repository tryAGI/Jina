
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingsV5RequestTask2
    {
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
        TextMatching,
        /// <summary>
        /// 
        /// </summary>
        Clustering,
        /// <summary>
        /// 
        /// </summary>
        Classification,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsV5RequestTask2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV5RequestTask2 value)
        {
            return value switch
            {
                EmbeddingsV5RequestTask2.RetrievalQuery => "retrieval.query",
                EmbeddingsV5RequestTask2.RetrievalPassage => "retrieval.passage",
                EmbeddingsV5RequestTask2.TextMatching => "text-matching",
                EmbeddingsV5RequestTask2.Clustering => "clustering",
                EmbeddingsV5RequestTask2.Classification => "classification",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV5RequestTask2? ToEnum(string value)
        {
            return value switch
            {
                "retrieval.query" => EmbeddingsV5RequestTask2.RetrievalQuery,
                "retrieval.passage" => EmbeddingsV5RequestTask2.RetrievalPassage,
                "text-matching" => EmbeddingsV5RequestTask2.TextMatching,
                "clustering" => EmbeddingsV5RequestTask2.Clustering,
                "classification" => EmbeddingsV5RequestTask2.Classification,
                _ => null,
            };
        }
    }
}