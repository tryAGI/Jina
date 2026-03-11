
#nullable enable

namespace Jina
{
    /// <summary>
    /// The sparse embedding model to use.
    /// </summary>
    public enum ELSERV2RequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        ElserV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ELSERV2RequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ELSERV2RequestModel value)
        {
            return value switch
            {
                ELSERV2RequestModel.ElserV2 => "elser-v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ELSERV2RequestModel? ToEnum(string value)
        {
            return value switch
            {
                "elser-v2" => ELSERV2RequestModel.ElserV2,
                _ => null,
            };
        }
    }
}