
#nullable enable

namespace Jina
{
    /// <summary>
    /// Status of a batch embedding job.
    /// </summary>
    public sealed partial class BatchStatus
    {
        /// <summary>
        /// Unique identifier for the batch job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BatchId { get; set; }

        /// <summary>
        /// Current status of the batch job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Jina.JsonConverters.BatchStatusStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Jina.BatchStatusStatus Status { get; set; }

        /// <summary>
        /// The model used for embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when job completed (if finished).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp when output URL expires (created_at + 24h).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// Signed URL to download output JSONL (24h expiry).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_url")]
        public string? OutputUrl { get; set; }

        /// <summary>
        /// URL to download error JSONL for failed lines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_file_url")]
        public string? ErrorFileUrl { get; set; }

        /// <summary>
        /// Error message if job failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Processing statistics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::Jina.BatchStats? Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchStatus" /> class.
        /// </summary>
        /// <param name="batchId">
        /// Unique identifier for the batch job.
        /// </param>
        /// <param name="status">
        /// Current status of the batch job.
        /// </param>
        /// <param name="model">
        /// The model used for embedding.
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp when job was created.
        /// </param>
        /// <param name="completedAt">
        /// ISO 8601 timestamp when job completed (if finished).
        /// </param>
        /// <param name="expiresAt">
        /// ISO 8601 timestamp when output URL expires (created_at + 24h).
        /// </param>
        /// <param name="outputUrl">
        /// Signed URL to download output JSONL (24h expiry).
        /// </param>
        /// <param name="errorFileUrl">
        /// URL to download error JSONL for failed lines.
        /// </param>
        /// <param name="error">
        /// Error message if job failed.
        /// </param>
        /// <param name="stats">
        /// Processing statistics.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchStatus(
            string batchId,
            global::Jina.BatchStatusStatus status,
            string model,
            string createdAt,
            string? completedAt,
            string? expiresAt,
            string? outputUrl,
            string? errorFileUrl,
            string? error,
            global::Jina.BatchStats? stats)
        {
            this.BatchId = batchId ?? throw new global::System.ArgumentNullException(nameof(batchId));
            this.Status = status;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CompletedAt = completedAt;
            this.ExpiresAt = expiresAt;
            this.OutputUrl = outputUrl;
            this.ErrorFileUrl = errorFileUrl;
            this.Error = error;
            this.Stats = stats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchStatus" /> class.
        /// </summary>
        public BatchStatus()
        {
        }
    }
}