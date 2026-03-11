
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum ELSERV2RequestTask2
    {
        /// <summary>
        /// 
        /// </summary>
        RetrievalQuery,
        /// <summary>
        /// 
        /// </summary>
        RetrievalPassage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ELSERV2RequestTask2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ELSERV2RequestTask2 value)
        {
            return value switch
            {
                ELSERV2RequestTask2.RetrievalQuery => "retrieval.query",
                ELSERV2RequestTask2.RetrievalPassage => "retrieval.passage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ELSERV2RequestTask2? ToEnum(string value)
        {
            return value switch
            {
                "retrieval.query" => ELSERV2RequestTask2.RetrievalQuery,
                "retrieval.passage" => ELSERV2RequestTask2.RetrievalPassage,
                _ => null,
            };
        }
    }
}