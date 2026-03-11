
#nullable enable

namespace Jina
{
    /// <summary>
    /// CLIP model for zero-shot classification of images and text.
    /// </summary>
    public enum ClipCreateTrainingRequestModel
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
    public static class ClipCreateTrainingRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipCreateTrainingRequestModel value)
        {
            return value switch
            {
                ClipCreateTrainingRequestModel.JinaClipV1 => "jina-clip-v1",
                ClipCreateTrainingRequestModel.JinaClipV2 => "jina-clip-v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipCreateTrainingRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "jina-clip-v1" => ClipCreateTrainingRequestModel.JinaClipV1,
                "jina-clip-v2" => ClipCreateTrainingRequestModel.JinaClipV2,
                _ => null,
            };
        }
    }
}