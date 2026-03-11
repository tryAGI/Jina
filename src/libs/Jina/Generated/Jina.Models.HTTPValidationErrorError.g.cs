
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HTTPValidationErrorError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        public string? Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPValidationErrorError" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <param name="input"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HTTPValidationErrorError(
            string? field,
            string? message,
            string? type,
            object? input)
        {
            this.Field = field;
            this.Message = message;
            this.Type = type;
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPValidationErrorError" /> class.
        /// </summary>
        public HTTPValidationErrorError()
        {
        }
    }
}