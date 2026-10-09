
#nullable enable

namespace Jina
{
    /// <summary>
    /// One rejected field, as carried in a 422.
    /// </summary>
    public sealed partial class FieldError
    {
        /// <summary>
        /// Path to the field, e.g. `body -&gt; input -&gt; 0`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// The rejected value. Long strings are truncated and containers dropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// Why the value was rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Validator that rejected it, e.g. `string_type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldError" /> class.
        /// </summary>
        /// <param name="field">
        /// Path to the field, e.g. `body -&gt; input -&gt; 0`.
        /// </param>
        /// <param name="message">
        /// Why the value was rejected.
        /// </param>
        /// <param name="type">
        /// Validator that rejected it, e.g. `string_type`.
        /// </param>
        /// <param name="input">
        /// The rejected value. Long strings are truncated and containers dropped.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FieldError(
            string field,
            string message,
            string type,
            object? input)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Input = input;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldError" /> class.
        /// </summary>
        public FieldError()
        {
        }

    }
}