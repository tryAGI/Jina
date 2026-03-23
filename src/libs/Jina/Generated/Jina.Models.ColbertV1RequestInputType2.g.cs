
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum ColbertV1RequestInputType2
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
    public static class ColbertV1RequestInputType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColbertV1RequestInputType2 value)
        {
            return value switch
            {
                ColbertV1RequestInputType2.Document => "document",
                ColbertV1RequestInputType2.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColbertV1RequestInputType2? ToEnum(string value)
        {
            return value switch
            {
                "document" => ColbertV1RequestInputType2.Document,
                "query" => ColbertV1RequestInputType2.Query,
                _ => null,
            };
        }
    }
}