
#nullable enable

namespace Jina
{
    /// <summary>
    /// The ColBERT model to use.
    /// </summary>
    public enum ColbertV1RequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        JinaColbertV1En,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ColbertV1RequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColbertV1RequestModel value)
        {
            return value switch
            {
                ColbertV1RequestModel.JinaColbertV1En => "jina-colbert-v1-en",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColbertV1RequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-colbert-v1-en" => ColbertV1RequestModel.JinaColbertV1En,
                _ => null,
            };
        }
    }
}