
#nullable enable

namespace Jina
{
    /// <summary>
    /// Failure shape for every endpoint except `/v1/chat/completions`.
    /// </summary>
    public sealed partial class ErrorResponse
    {
        /// <summary>
        /// Machine-readable error code, for programmatic handling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Human-readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// Per-field detail. Present on 422 only; `detail` summarises it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::Jina.FieldError>? Errors { get; set; }

        /// <summary>
        /// Identifier for this request, quote it in support requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="detail">
        /// Human-readable error message.
        /// </param>
        /// <param name="code">
        /// Machine-readable error code, for programmatic handling.
        /// </param>
        /// <param name="errors">
        /// Per-field detail. Present on 422 only; `detail` summarises it.
        /// </param>
        /// <param name="requestId">
        /// Identifier for this request, quote it in support requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponse(
            string detail,
            string? code,
            global::System.Collections.Generic.IList<global::Jina.FieldError>? errors,
            string? requestId)
        {
            this.Code = code;
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.Errors = errors;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        public ErrorResponse()
        {
        }

    }
}