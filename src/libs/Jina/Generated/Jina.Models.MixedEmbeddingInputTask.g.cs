
#nullable enable

namespace Jina
{
    /// <summary>
    /// Used to convey intended downstream application to help the model produce better embeddings. Must be one of the following values:<br/>
    /// - "retrieval.query": Specifies the given text is a query in a search or retrieval setting.<br/>
    /// - "retrieval.passage": Specifies the given text is a document in a search or retrieval setting.<br/>
    /// - "text-matching": Specifies the given text is used for Semantic Textual Similarity.<br/>
    /// - "classification": Specifies that the embedding is used for classification.<br/>
    /// - "separation": Specifies that the embedding is used for clustering.
    /// </summary>
    public enum MixedEmbeddingInputTask
    {
        /// <summary>
        /// Specifies the given text is a query in a search or retrieval setting.
        /// </summary>
        RetrievalQuery,
        /// <summary>
        /// Specifies the given text is a document in a search or retrieval setting.
        /// </summary>
        RetrievalPassage,
        /// <summary>
        /// Specifies the given text is used for Semantic Textual Similarity.
        /// </summary>
        TextMatching,
        /// <summary>
        /// Specifies that the embedding is used for classification.
        /// </summary>
        Classification,
        /// <summary>
        /// Specifies that the embedding is used for clustering.
        /// </summary>
        Separation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MixedEmbeddingInputTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MixedEmbeddingInputTask value)
        {
            return value switch
            {
                MixedEmbeddingInputTask.RetrievalQuery => "retrieval.query",
                MixedEmbeddingInputTask.RetrievalPassage => "retrieval.passage",
                MixedEmbeddingInputTask.TextMatching => "text-matching",
                MixedEmbeddingInputTask.Classification => "classification",
                MixedEmbeddingInputTask.Separation => "separation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MixedEmbeddingInputTask? ToEnum(string value)
        {
            return value switch
            {
                "retrieval.query" => MixedEmbeddingInputTask.RetrievalQuery,
                "retrieval.passage" => MixedEmbeddingInputTask.RetrievalPassage,
                "text-matching" => MixedEmbeddingInputTask.TextMatching,
                "classification" => MixedEmbeddingInputTask.Classification,
                "separation" => MixedEmbeddingInputTask.Separation,
                _ => null,
            };
        }
    }
}