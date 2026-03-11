
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingsV1EmbeddingsPostRequestDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModelJsonConverter))]
        public global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsV1EmbeddingsPostRequestDiscriminator" /> class.
        /// </summary>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsV1EmbeddingsPostRequestDiscriminator(
            global::Jina.EmbeddingsV1EmbeddingsPostRequestDiscriminatorModel? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsV1EmbeddingsPostRequestDiscriminator" /> class.
        /// </summary>
        public EmbeddingsV1EmbeddingsPostRequestDiscriminator()
        {
        }
    }
}