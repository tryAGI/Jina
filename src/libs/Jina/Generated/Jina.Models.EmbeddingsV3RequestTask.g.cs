
#nullable enable

namespace Jina
{
    /// <summary>
    /// Task optimization: `retrieval.query` for queries, `retrieval.passage` for documents, `text-matching` for similarity, `classification`, or `separation` for clustering.
    /// </summary>
    public enum EmbeddingsV3RequestTask
    {
        /// <summary>
        /// `retrieval.query` for queries, `retrieval.passage` for documents, `text-matching` for similarity, `classification`, or `separation` for clustering.
        /// </summary>
        RetrievalQuery,
        /// <summary>
        /// `retrieval.query` for queries, `retrieval.passage` for documents, `text-matching` for similarity, `classification`, or `separation` for clustering.
        /// </summary>
        RetrievalPassage,
        /// <summary>
        /// `retrieval.query` for queries, `retrieval.passage` for documents, `text-matching` for similarity, `classification`, or `separation` for clustering.
        /// </summary>
        TextMatching,
        /// <summary>
        /// `retrieval.query` for queries, `retrieval.passage` for documents, `text-matching` for similarity, `classification`, or `separation` for clustering.
        /// </summary>
        Classification,
        /// <summary>
        /// `retrieval.query` for queries, `retrieval.passage` for documents, `text-matching` for similarity, `classification`, or `separation` for clustering.
        /// </summary>
        Separation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsV3RequestTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV3RequestTask value)
        {
            return value switch
            {
                EmbeddingsV3RequestTask.RetrievalQuery => "retrieval.query",
                EmbeddingsV3RequestTask.RetrievalPassage => "retrieval.passage",
                EmbeddingsV3RequestTask.TextMatching => "text-matching",
                EmbeddingsV3RequestTask.Classification => "classification",
                EmbeddingsV3RequestTask.Separation => "separation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV3RequestTask? ToEnum(string value)
        {
            return value switch
            {
                "retrieval.query" => EmbeddingsV3RequestTask.RetrievalQuery,
                "retrieval.passage" => EmbeddingsV3RequestTask.RetrievalPassage,
                "text-matching" => EmbeddingsV3RequestTask.TextMatching,
                "classification" => EmbeddingsV3RequestTask.Classification,
                "separation" => EmbeddingsV3RequestTask.Separation,
                _ => null,
            };
        }
    }
}