
#nullable enable

namespace Jina
{
    /// <summary>
    /// The CLIP model to use.
    /// </summary>
    public enum ClipZeroShotClassificationRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        JinaClipV1,
        /// <summary>
        /// 
        /// </summary>
        JinaClipV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipZeroShotClassificationRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipZeroShotClassificationRequestModel value)
        {
            return value switch
            {
                ClipZeroShotClassificationRequestModel.JinaClipV1 => "jina-clip-v1",
                ClipZeroShotClassificationRequestModel.JinaClipV2 => "jina-clip-v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipZeroShotClassificationRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-clip-v1" => ClipZeroShotClassificationRequestModel.JinaClipV1,
                "jina-clip-v2" => ClipZeroShotClassificationRequestModel.JinaClipV2,
                _ => null,
            };
        }
    }
}