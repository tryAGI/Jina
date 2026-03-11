
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingsV3RequestTask2
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
        Classification,
        /// <summary>
        /// 
        /// </summary>
        Separation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsV3RequestTask2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsV3RequestTask2 value)
        {
            return value switch
            {
                EmbeddingsV3RequestTask2.RetrievalQuery => "retrieval.query",
                EmbeddingsV3RequestTask2.RetrievalPassage => "retrieval.passage",
                EmbeddingsV3RequestTask2.TextMatching => "text-matching",
                EmbeddingsV3RequestTask2.Classification => "classification",
                EmbeddingsV3RequestTask2.Separation => "separation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsV3RequestTask2? ToEnum(string value)
        {
            return value switch
            {
                "retrieval.query" => EmbeddingsV3RequestTask2.RetrievalQuery,
                "retrieval.passage" => EmbeddingsV3RequestTask2.RetrievalPassage,
                "text-matching" => EmbeddingsV3RequestTask2.TextMatching,
                "classification" => EmbeddingsV3RequestTask2.Classification,
                "separation" => EmbeddingsV3RequestTask2.Separation,
                _ => null,
            };
        }
    }
}