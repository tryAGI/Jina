
#nullable enable

namespace Jina
{
    /// <summary>
    /// Datacenter location for a model.
    /// </summary>
    public sealed partial class ModelDatacenter
    {
        /// <summary>
        /// ISO country code of the datacenter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string CountryCode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDatacenter" /> class.
        /// </summary>
        /// <param name="countryCode">
        /// ISO country code of the datacenter.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelDatacenter(
            string countryCode)
        {
            this.CountryCode = countryCode ?? throw new global::System.ArgumentNullException(nameof(countryCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDatacenter" /> class.
        /// </summary>
        public ModelDatacenter()
        {
        }
    }
}