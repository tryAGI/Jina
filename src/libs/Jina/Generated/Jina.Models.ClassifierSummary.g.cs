
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifierSummary
    {
        /// <summary>
        /// Access level (e.g., private, public)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Access { get; set; }

        /// <summary>
        /// Unique identifier for the classifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ClassifierId { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Whether the classifier is currently active<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Whether this is the latest version of the classifier<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_latest")]
        public bool? IsLatest { get; set; }

        /// <summary>
        /// List of classification labels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// Additional metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Name of the model used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Last update timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Number of times updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedNumber { get; set; }

        /// <summary>
        /// Last used timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_at")]
        public global::System.DateTime? UsedAt { get; set; }

        /// <summary>
        /// Number of times used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UsedNumber { get; set; }

        /// <summary>
        /// User ID who owns the classifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierSummary" /> class.
        /// </summary>
        /// <param name="access">
        /// Access level (e.g., private, public)
        /// </param>
        /// <param name="classifierId">
        /// Unique identifier for the classifier
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="isActive">
        /// Whether the classifier is currently active<br/>
        /// Default Value: true
        /// </param>
        /// <param name="isLatest">
        /// Whether this is the latest version of the classifier<br/>
        /// Default Value: true
        /// </param>
        /// <param name="labels">
        /// List of classification labels
        /// </param>
        /// <param name="metadata">
        /// Additional metadata
        /// </param>
        /// <param name="model">
        /// Name of the model used
        /// </param>
        /// <param name="updatedAt">
        /// Last update timestamp
        /// </param>
        /// <param name="updatedNumber">
        /// Number of times updated
        /// </param>
        /// <param name="usedAt">
        /// Last used timestamp
        /// </param>
        /// <param name="usedNumber">
        /// Number of times used
        /// </param>
        /// <param name="userId">
        /// User ID who owns the classifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifierSummary(
            string access,
            global::System.Guid classifierId,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<string> labels,
            string model,
            global::System.DateTime updatedAt,
            int updatedNumber,
            int usedNumber,
            global::System.Guid userId,
            bool? isActive,
            bool? isLatest,
            object? metadata,
            global::System.DateTime? usedAt)
        {
            this.Access = access ?? throw new global::System.ArgumentNullException(nameof(access));
            this.ClassifierId = classifierId;
            this.CreatedAt = createdAt;
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.UpdatedAt = updatedAt;
            this.UpdatedNumber = updatedNumber;
            this.UsedNumber = usedNumber;
            this.UserId = userId;
            this.IsActive = isActive;
            this.IsLatest = isLatest;
            this.Metadata = metadata;
            this.UsedAt = usedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierSummary" /> class.
        /// </summary>
        public ClassifierSummary()
        {
        }
    }
}