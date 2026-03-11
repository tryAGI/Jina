
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifyV1ClassifyPostRequestVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModelJsonConverter))]
        public global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyV1ClassifyPostRequestVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifyV1ClassifyPostRequestVariant1Discriminator(
            global::Jina.ClassifyV1ClassifyPostRequestVariant1DiscriminatorModel? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyV1ClassifyPostRequestVariant1Discriminator" /> class.
        /// </summary>
        public ClassifyV1ClassifyPostRequestVariant1Discriminator()
        {
        }
    }
}