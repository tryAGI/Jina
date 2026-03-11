
#nullable enable

namespace Jina
{
    /// <summary>
    /// Task optimization: `retrieval.query` for queries, `retrieval.passage` for documents.
    /// </summary>
    public enum ELSERV2RequestTask
    {
        /// <summary>
        /// `retrieval.query` for queries, `retrieval.passage` for documents.
        /// </summary>
        RetrievalQuery,
        /// <summary>
        /// `retrieval.query` for queries, `retrieval.passage` for documents.
        /// </summary>
        RetrievalPassage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ELSERV2RequestTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ELSERV2RequestTask value)
        {
            return value switch
            {
                ELSERV2RequestTask.RetrievalQuery => "retrieval.query",
                ELSERV2RequestTask.RetrievalPassage => "retrieval.passage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ELSERV2RequestTask? ToEnum(string value)
        {
            return value switch
            {
                "retrieval.query" => ELSERV2RequestTask.RetrievalQuery,
                "retrieval.passage" => ELSERV2RequestTask.RetrievalPassage,
                _ => null,
            };
        }
    }
}