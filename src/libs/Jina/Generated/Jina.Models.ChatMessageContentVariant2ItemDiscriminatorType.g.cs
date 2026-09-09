
#nullable enable

namespace Jina
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatMessageContentVariant2ItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ImageUrl,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                ChatMessageContentVariant2ItemDiscriminatorType.ImageUrl => "image_url",
                ChatMessageContentVariant2ItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ChatMessageContentVariant2ItemDiscriminatorType.ImageUrl,
                "text" => ChatMessageContentVariant2ItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}