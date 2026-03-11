
#nullable enable

namespace Jina
{
    /// <summary>
    /// Set to `retrieval.query` to optimize for search queries. Leave unset for documents.
    /// </summary>
    public enum ClipV2RequestTask
    {
        /// <summary>
        /// 
        /// </summary>
        RetrievalQuery,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipV2RequestTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipV2RequestTask value)
        {
            return value switch
            {
                ClipV2RequestTask.RetrievalQuery => "retrieval.query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipV2RequestTask? ToEnum(string value)
        {
            return value switch
            {
                "retrieval.query" => ClipV2RequestTask.RetrievalQuery,
                _ => null,
            };
        }
    }
}