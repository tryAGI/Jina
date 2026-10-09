
#nullable enable

namespace Jina
{
    /// <summary>
    /// Pricing information for a model.
    /// </summary>
    public sealed partial class ModelPricing
    {
        /// <summary>
        /// USD per output token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Completion { get; set; }

        /// <summary>
        /// USD per image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// USD per cached input token read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_read")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputCacheRead { get; set; }

        /// <summary>
        /// USD per cached input token written.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_write")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputCacheWrite { get; set; }

        /// <summary>
        /// USD per input token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// USD per request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricing" /> class.
        /// </summary>
        /// <param name="completion">
        /// USD per output token.
        /// </param>
        /// <param name="image">
        /// USD per image.
        /// </param>
        /// <param name="inputCacheRead">
        /// USD per cached input token read.
        /// </param>
        /// <param name="inputCacheWrite">
        /// USD per cached input token written.
        /// </param>
        /// <param name="prompt">
        /// USD per input token.
        /// </param>
        /// <param name="request">
        /// USD per request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPricing(
            string completion,
            string image,
            string inputCacheRead,
            string inputCacheWrite,
            string prompt,
            string request)
        {
            this.Completion = completion ?? throw new global::System.ArgumentNullException(nameof(completion));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.InputCacheRead = inputCacheRead ?? throw new global::System.ArgumentNullException(nameof(inputCacheRead));
            this.InputCacheWrite = inputCacheWrite ?? throw new global::System.ArgumentNullException(nameof(inputCacheWrite));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricing" /> class.
        /// </summary>
        public ModelPricing()
        {
        }

    }
}