
#nullable enable

namespace Jina
{
    /// <summary>
    /// The CLIP model to use.
    /// </summary>
    public enum ClipV2RequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        JinaClipV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipV2RequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipV2RequestModel value)
        {
            return value switch
            {
                ClipV2RequestModel.JinaClipV2 => "jina-clip-v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipV2RequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-clip-v2" => ClipV2RequestModel.JinaClipV2,
                _ => null,
            };
        }
    }
}