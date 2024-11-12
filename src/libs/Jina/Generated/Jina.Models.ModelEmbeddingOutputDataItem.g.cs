
#nullable enable

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelEmbeddingOutputDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        public global::System.Collections.Generic.IList<float>? Embedding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelEmbeddingOutputDataItem" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="embedding"></param>
        /// <param name="object"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ModelEmbeddingOutputDataItem(
            int? index,
            global::System.Collections.Generic.IList<float>? embedding,
            string? @object)
        {
            this.Index = index;
            this.Embedding = embedding;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelEmbeddingOutputDataItem" /> class.
        /// </summary>
        public ModelEmbeddingOutputDataItem()
        {
        }
    }
}