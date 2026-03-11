
#nullable enable

namespace Jina
{
    /// <summary>
    /// Role of the input: `query` for search queries, `document` for passages.<br/>
    /// Default Value: document
    /// </summary>
    public enum ColbertV1RequestInputType
    {
        /// <summary>
        /// `query` for search queries, `document` for passages.
        /// </summary>
        Query,
        /// <summary>
        /// `query` for search queries, `document` for passages.
        /// </summary>
        Document,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ColbertV1RequestInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColbertV1RequestInputType value)
        {
            return value switch
            {
                ColbertV1RequestInputType.Query => "query",
                ColbertV1RequestInputType.Document => "document",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColbertV1RequestInputType? ToEnum(string value)
        {
            return value switch
            {
                "query" => ColbertV1RequestInputType.Query,
                "document" => ColbertV1RequestInputType.Document,
                _ => null,
            };
        }
    }
}