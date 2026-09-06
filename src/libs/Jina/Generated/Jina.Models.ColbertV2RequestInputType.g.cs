
#nullable enable

namespace Jina
{
    /// <summary>
    ///
    /// </summary>
    public enum ColbertV2RequestInputType
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
    public static class ColbertV2RequestInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColbertV2RequestInputType value)
        {
            return value switch
            {
                ColbertV2RequestInputType.Document => "document",
                ColbertV2RequestInputType.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColbertV2RequestInputType? ToEnum(string value)
        {
            return value switch
            {
                "document" => ColbertV2RequestInputType.Document,
                "query" => ColbertV2RequestInputType.Query,
                _ => null,
            };
        }
    }
}