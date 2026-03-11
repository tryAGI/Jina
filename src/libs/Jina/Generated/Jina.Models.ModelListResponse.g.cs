
#nullable enable

namespace Jina
{
    /// <summary>
    /// Response containing list of available models.<br/>
    /// Example: {"data":[{"context_length":8192,"created":1725840000,"datacenters":[{"country_code":"US"}],"description":"jina-embeddings-v3 is a multilingual embedding model...","hugging_face_id":"jinaai/jina-embeddings-v3","id":"jina-ai/jina-embeddings-v3","input_modalities":["text"],"max_output_length":1024,"name":"Jina AI: Jina Embeddings v3","output_modalities":["embeddings"],"pricing":{"completion":"0","image":"0","input_cache_read":"0","input_cache_write":"0","prompt":"0.00000005","request":"0"},"quantization":"","supported_features":[],"supported_sampling_parameters":[]}]}
    /// </summary>
    public sealed partial class ModelListResponse
    {
        /// <summary>
        /// List of available models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Jina.ModelInfo> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of available models.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelListResponse(
            global::System.Collections.Generic.IList<global::Jina.ModelInfo> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelListResponse" /> class.
        /// </summary>
        public ModelListResponse()
        {
        }
    }
}