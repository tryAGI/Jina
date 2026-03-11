
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HTTPValidationError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::Jina.HTTPValidationErrorError>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPValidationError" /> class.
        /// </summary>
        /// <param name="detail"></param>
        /// <param name="errors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HTTPValidationError(
            string? detail,
            global::System.Collections.Generic.IList<global::Jina.HTTPValidationErrorError>? errors)
        {
            this.Detail = detail;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPValidationError" /> class.
        /// </summary>
        public HTTPValidationError()
        {
        }
    }
}