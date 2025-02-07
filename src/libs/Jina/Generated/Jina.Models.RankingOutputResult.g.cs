
#nullable enable

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
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public long? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevance_score")]
        public double? RelevanceScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public global::Jina.RankingOutputResultDocument? Document { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RankingOutputResult" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="relevanceScore"></param>
        /// <param name="document"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RankingOutputResult(
            long? index,
            double? relevanceScore,
            global::Jina.RankingOutputResultDocument? document)
        {
            this.Index = index;
            this.RelevanceScore = relevanceScore;
            this.Document = document;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankingOutputResult" /> class.
        /// </summary>
        public RankingOutputResult()
        {
        }
    }
}