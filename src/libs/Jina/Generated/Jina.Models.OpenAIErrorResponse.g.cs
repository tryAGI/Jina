
#nullable enable

namespace Jina
{
    /// <summary>
    /// Failure shape for `/v1/chat/completions`, so OpenAI clients parse it.
    /// </summary>
    public sealed partial class OpenAIErrorResponse
    {
        /// <summary>
        /// OpenAI's error object. Our `code` and `request_id` ride inside it because<br/>
        /// the OpenAI SDK keeps `body["error"]` and discards everything beside it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.OpenAIError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIErrorResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// OpenAI's error object. Our `code` and `request_id` ride inside it because<br/>
        /// the OpenAI SDK keeps `body["error"]` and discards everything beside it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIErrorResponse(
            global::Jina.OpenAIError error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIErrorResponse" /> class.
        /// </summary>
        public OpenAIErrorResponse()
        {
        }

    }
}