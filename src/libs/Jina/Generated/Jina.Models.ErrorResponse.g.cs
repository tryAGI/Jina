
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorResponse
    {
        /// <summary>
        /// Machine-readable error code for programmatic handling<br/>
        /// Example: AUTH_INVALID_API_KEY
        /// </summary>
        /// <example>AUTH_INVALID_API_KEY</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Human-readable error message<br/>
        /// Example: Invalid API key. Verify your API key at https://jina.ai/api-dashboard/key-manager or generate a new one.
        /// </summary>
        /// <example>Invalid API key. Verify your API key at https://jina.ai/api-dashboard/key-manager or generate a new one.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// Unique request identifier for tracing and support<br/>
        /// Example: 03f58cd9da22fabf
        /// </summary>
        /// <example>03f58cd9da22fabf</example>
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
        /// <param name="code">
        /// Machine-readable error code for programmatic handling<br/>
        /// Example: AUTH_INVALID_API_KEY
        /// </param>
        /// <param name="detail">
        /// Human-readable error message<br/>
        /// Example: Invalid API key. Verify your API key at https://jina.ai/api-dashboard/key-manager or generate a new one.
        /// </param>
        /// <param name="requestId">
        /// Unique request identifier for tracing and support<br/>
        /// Example: 03f58cd9da22fabf
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponse(
            string detail,
            string? code,
            string? requestId)
        {
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.Code = code;
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