
#nullable enable

namespace Jina
{
    /// <summary>
    /// Request to create a batch embedding job.
    /// </summary>
    public sealed partial class BatchEmbeddingRequest
    {
        /// <summary>
        /// Number of dimensions for output embeddings (1-1024).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// Inline JSONL lines for small batches. Either input_url or input must be provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::System.Collections.Generic.IList<object>? Input { get; set; }

        /// <summary>
        /// URL to input JSONL file (GCS, S3, or HTTP). Either input_url or input must be provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_url")]
        public string? InputUrl { get; set; }

        /// <summary>
        /// The embedding model to use for batch processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.BatchEmbeddingRequestModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.BatchEmbeddingRequestModel Model { get; set; }

        /// <summary>
        /// If true (default), embeddings are L2-normalized to unit length.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized")]
        public bool? Normalized { get; set; }

        /// <summary>
        /// Task optimization: retrieval, text-matching, clustering, or classification.<br/>
        /// Default Value: text-matching
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public string? Task { get; set; }

        /// <summary>
        /// URL to POST notification when job completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchEmbeddingRequest" /> class.
        /// </summary>
        /// <param name="dimensions">
        /// Number of dimensions for output embeddings (1-1024).
        /// </param>
        /// <param name="input">
        /// Inline JSONL lines for small batches. Either input_url or input must be provided.
        /// </param>
        /// <param name="inputUrl">
        /// URL to input JSONL file (GCS, S3, or HTTP). Either input_url or input must be provided.
        /// </param>
        /// <param name="model">
        /// The embedding model to use for batch processing.
        /// </param>
        /// <param name="normalized">
        /// If true (default), embeddings are L2-normalized to unit length.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="task">
        /// Task optimization: retrieval, text-matching, clustering, or classification.<br/>
        /// Default Value: text-matching
        /// </param>
        /// <param name="webhookUrl">
        /// URL to POST notification when job completes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchEmbeddingRequest(
            global::Jina.BatchEmbeddingRequestModel model,
            int? dimensions,
            global::System.Collections.Generic.IList<object>? input,
            string? inputUrl,
            bool? normalized,
            string? task,
            string? webhookUrl)
        {
            this.Model = model;
            this.Dimensions = dimensions;
            this.Input = input;
            this.InputUrl = inputUrl;
            this.Normalized = normalized;
            this.Task = task;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchEmbeddingRequest" /> class.
        /// </summary>
        public BatchEmbeddingRequest()
        {
        }
    }
}