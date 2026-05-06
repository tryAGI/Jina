
#nullable enable

namespace Jina
{
    /// <summary>
    /// Mixed-modality chunks fused into ONE embedding per group.<br/>
    /// The executor sends every chunk to the model in a single forward pass<br/>
    /// (interleaved per the model's special-token convention) and returns one<br/>
    /// vector per `MergedContentGroup`. Order within `content` is semantically<br/>
    /// meaningful — re-ordering may change the resulting embedding.<br/>
    /// PDFs are intentionally not allowed inside `content`: they're rasterized<br/>
    /// to N per-page image prompts, which doesn't compose with single-pass<br/>
    /// fusion. Send PDFs as standalone single-input requests instead.
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