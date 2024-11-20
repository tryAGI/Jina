
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
    public enum ImageEmbeddingInputTask
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
    public static class ImageEmbeddingInputTaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEmbeddingInputTask value)
        {
            return value switch
            {
                ImageEmbeddingInputTask.RetrievalQuery => "retrieval.query",
                ImageEmbeddingInputTask.RetrievalPassage => "retrieval.passage",
                ImageEmbeddingInputTask.TextMatching => "text-matching",
                ImageEmbeddingInputTask.Classification => "classification",
                ImageEmbeddingInputTask.Separation => "separation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEmbeddingInputTask? ToEnum(string value)
        {
            return value switch
            {
                "retrieval.query" => ImageEmbeddingInputTask.RetrievalQuery,
                "retrieval.passage" => ImageEmbeddingInputTask.RetrievalPassage,
                "text-matching" => ImageEmbeddingInputTask.TextMatching,
                "classification" => ImageEmbeddingInputTask.Classification,
                "separation" => ImageEmbeddingInputTask.Separation,
                _ => null,
            };
        }
    }
}