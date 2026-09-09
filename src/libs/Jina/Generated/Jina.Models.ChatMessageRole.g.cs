
#nullable enable

namespace Jina
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        Developer,
        /// <summary>
        ///
        /// </summary>
        System,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageRole value)
        {
            return value switch
            {
                ChatMessageRole.Assistant => "assistant",
                ChatMessageRole.Developer => "developer",
                ChatMessageRole.System => "system",
                ChatMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatMessageRole.Assistant,
                "developer" => ChatMessageRole.Developer,
                "system" => ChatMessageRole.System,
                "user" => ChatMessageRole.User,
                _ => null,
            };
        }
    }
}