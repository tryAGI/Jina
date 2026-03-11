
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public enum ColbertV2RequestInputType2
    {
        /// <summary>
        /// 
        /// </summary>
        Query,
        /// <summary>
        /// 
        /// </summary>
        Document,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ColbertV2RequestInputType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColbertV2RequestInputType2 value)
        {
            return value switch
            {
                ColbertV2RequestInputType2.Query => "query",
                ColbertV2RequestInputType2.Document => "document",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColbertV2RequestInputType2? ToEnum(string value)
        {
            return value switch
            {
                "query" => ColbertV2RequestInputType2.Query,
                "document" => ColbertV2RequestInputType2.Document,
                _ => null,
            };
        }
    }
}