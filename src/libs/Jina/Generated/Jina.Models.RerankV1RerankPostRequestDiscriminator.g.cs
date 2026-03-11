
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankV1RerankPostRequestDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.RerankV1RerankPostRequestDiscriminatorModelJsonConverter))]
        public global::Jina.RerankV1RerankPostRequestDiscriminatorModel? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankV1RerankPostRequestDiscriminator" /> class.
        /// </summary>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankV1RerankPostRequestDiscriminator(
            global::Jina.RerankV1RerankPostRequestDiscriminatorModel? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankV1RerankPostRequestDiscriminator" /> class.
        /// </summary>
        public RerankV1RerankPostRequestDiscriminator()
        {
        }
    }
}