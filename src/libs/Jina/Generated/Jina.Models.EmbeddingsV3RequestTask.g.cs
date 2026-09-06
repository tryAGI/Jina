
#nullable enable

namespace Jina
{
    /// <summary>
    ///
    /// </summary>
    public enum EmbeddingsV3RequestTask
    {
        /// <summary>
        ///
        /// </summary>
        Classification,
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
        Separation,
        /// <summary>
        ///
        /// </summary>
        TextMatching,
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
                EmbeddingsV3RequestTask.Classification => "classification",
                EmbeddingsV3RequestTask.RetrievalPassage => "retrieval.passage",
                EmbeddingsV3RequestTask.RetrievalQuery => "retrieval.query",
                EmbeddingsV3RequestTask.Separation => "separation",
                EmbeddingsV3RequestTask.TextMatching => "text-matching",
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
                "classification" => EmbeddingsV3RequestTask.Classification,
                "retrieval.passage" => EmbeddingsV3RequestTask.RetrievalPassage,
                "retrieval.query" => EmbeddingsV3RequestTask.RetrievalQuery,
                "separation" => EmbeddingsV3RequestTask.Separation,
                "text-matching" => EmbeddingsV3RequestTask.TextMatching,
                _ => null,
            };
        }
    }
}