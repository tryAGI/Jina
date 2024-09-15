#nullable enable

using System.Text.Json.Serialization;

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
        [JsonPropertyName("embedding")]
        public IReadOnlyList<float>? Embedding { get; set; }
    }
}