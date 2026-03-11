
#nullable enable

namespace Jina
{
    /// <summary>
    /// The ColBERT model to use.
    /// </summary>
    public enum ColbertV2RequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        JinaColbertV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ColbertV2RequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColbertV2RequestModel value)
        {
            return value switch
            {
                ColbertV2RequestModel.JinaColbertV2 => "jina-colbert-v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColbertV2RequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-colbert-v2" => ColbertV2RequestModel.JinaColbertV2,
                _ => null,
            };
        }
    }
}