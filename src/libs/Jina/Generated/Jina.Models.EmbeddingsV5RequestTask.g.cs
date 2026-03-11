
#nullable enable

namespace Jina
{
    /// <summary>
    /// Task optimization: `retrieval.query` for queries, `retrieval.passage` for documents, `text-matching` for similarity, `clustering`, or `classification`.<br/>
    /// Default Value: text-matching
    /// </summary>
    public enum EmbeddingsV5RequestTask
    {
        /// <summary>
        /// `retrieval.query` for queries, `retrieval.passage` for documents, `text-matching` for similarity, `clustering`, or `classification`.
        /// </summary>
        RetrievalQuery,
        /// <summary>
        /// `retrieval.query` for queries, `retrieval.passage` for documents, `text-matching` for similarity, `clustering`, or `classification`.
        /// </summary>
        RetrievalPassage,
        /// <summary>
        /// `retrieval.query` for queries, `retrieval.passage` for documents, `text-matching` for similarity, `clustering`, or `classification`.
        /// </summary>
        TextMatching,
        /// <summary>
        /// `retrieval.query` for queries, `retrieval.passage` for documents, `text-matching` for similarity, `clustering`, or `classification`.
        /// </summary>
        Clustering,
        /// <summary>
        /// `retrieval.query` for queries, `retrieval.passage` for documents, `text-matching` for similarity, `clustering`, or `classification`.
        /// </summary>
        Classification,
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
                EmbeddingsV5RequestTask.RetrievalQuery => "retrieval.query",
                EmbeddingsV5RequestTask.RetrievalPassage => "retrieval.passage",
                EmbeddingsV5RequestTask.TextMatching => "text-matching",
                EmbeddingsV5RequestTask.Clustering => "clustering",
                EmbeddingsV5RequestTask.Classification => "classification",
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
                "retrieval.query" => EmbeddingsV5RequestTask.RetrievalQuery,
                "retrieval.passage" => EmbeddingsV5RequestTask.RetrievalPassage,
                "text-matching" => EmbeddingsV5RequestTask.TextMatching,
                "clustering" => EmbeddingsV5RequestTask.Clustering,
                "classification" => EmbeddingsV5RequestTask.Classification,
                _ => null,
            };
        }
    }
}