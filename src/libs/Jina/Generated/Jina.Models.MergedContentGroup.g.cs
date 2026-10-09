
#nullable enable

namespace Jina
{
    /// <summary>
    /// Several chunks of different modalities fused into one embedding.<br/>
    /// The group returns a single vector, and order within `content` is part of<br/>
    /// the meaning — reordering it can change the result. A PDF cannot go inside<br/>
    /// a group; send it as its own input.
    /// </summary>
    public sealed partial class MergedContentGroup
    {
        /// <summary>
        /// Ordered list of modality chunks (text / image / video / audio). Must contain at least one chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MergedContentGroup" /> class.
        /// </summary>
        /// <param name="content">
        /// Ordered list of modality chunks (text / image / video / audio). Must contain at least one chunk.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MergedContentGroup(
            global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.TextDoc, global::Jina.ImageDoc, global::Jina.VideoDoc, global::Jina.AudioDoc>> content)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MergedContentGroup" /> class.
        /// </summary>
        public MergedContentGroup()
        {
        }

    }
}