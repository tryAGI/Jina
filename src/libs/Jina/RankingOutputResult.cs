#nullable enable

using System.Text.Json.Serialization;

namespace Jina
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RankingOutputResult
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("index")]
        public long Index { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("relevance_score")]
        public double RelevanceScore { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("document")]
        public ApiSchemasRankTextDoc? Document { get; set; }
    }
}