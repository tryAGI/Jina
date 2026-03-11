
#nullable enable

namespace Jina
{
    /// <summary>
    /// Pricing information for a model.
    /// </summary>
    public sealed partial class ModelPricing
    {
        /// <summary>
        /// Price per prompt token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Price per completion token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Completion { get; set; } = default!;

        /// <summary>
        /// Price per image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Image { get; set; } = default!;

        /// <summary>
        /// Price per request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Request { get; set; } = default!;

        /// <summary>
        /// Price for input cache read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_read")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string InputCacheRead { get; set; } = default!;

        /// <summary>
        /// Price for input cache write.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_write")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string InputCacheWrite { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricing" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Price per prompt token.
        /// </param>
        /// <param name="completion">
        /// Price per completion token.
        /// </param>
        /// <param name="image">
        /// Price per image.
        /// </param>
        /// <param name="request">
        /// Price per request.
        /// </param>
        /// <param name="inputCacheRead">
        /// Price for input cache read.
        /// </param>
        /// <param name="inputCacheWrite">
        /// Price for input cache write.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPricing(
            string prompt,
            string completion,
            string image,
            string request,
            string inputCacheRead,
            string inputCacheWrite)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Completion = completion ?? throw new global::System.ArgumentNullException(nameof(completion));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.InputCacheRead = inputCacheRead ?? throw new global::System.ArgumentNullException(nameof(inputCacheRead));
            this.InputCacheWrite = inputCacheWrite ?? throw new global::System.ArgumentNullException(nameof(inputCacheWrite));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricing" /> class.
        /// </summary>
        public ModelPricing()
        {
        }
    }
}