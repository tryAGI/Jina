
#nullable enable

namespace Jina
{
    /// <summary>
    /// The CLIP model to use.
    /// </summary>
    public enum ClipV1RequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        JinaClipV1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipV1RequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipV1RequestModel value)
        {
            return value switch
            {
                ClipV1RequestModel.JinaClipV1 => "jina-clip-v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipV1RequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-clip-v1" => ClipV1RequestModel.JinaClipV1,
                _ => null,
            };
        }
    }
}