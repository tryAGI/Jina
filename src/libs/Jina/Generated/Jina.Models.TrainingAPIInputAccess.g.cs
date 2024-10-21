
#nullable enable

namespace Jina
{
    /// <summary>
    /// The accessibility of the classifier when created. Will be ignored if `classifier_id` is provided<br/>
    /// Default Value: public
    /// </summary>
    public enum TrainingAPIInputAccess
    {
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Private,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrainingAPIInputAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainingAPIInputAccess value)
        {
            return value switch
            {
                TrainingAPIInputAccess.Public => "public",
                TrainingAPIInputAccess.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrainingAPIInputAccess? ToEnum(string value)
        {
            return value switch
            {
                "public" => TrainingAPIInputAccess.Public,
                "private" => TrainingAPIInputAccess.Private,
                _ => null,
            };
        }
    }
}