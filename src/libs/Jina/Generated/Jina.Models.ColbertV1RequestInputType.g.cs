
#nullable enable

namespace Jina
{
    /// <summary>
    ///
    /// </summary>
    public enum ColbertV1RequestInputType
    {
        /// <summary>
        ///
        /// </summary>
        Document,
        /// <summary>
        ///
        /// </summary>
        Query,
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
                ColbertV1RequestInputType.Document => "document",
                ColbertV1RequestInputType.Query => "query",
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
                "document" => ColbertV1RequestInputType.Document,
                "query" => ColbertV1RequestInputType.Query,
                _ => null,
            };
        }
    }
}