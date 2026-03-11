
#nullable enable

namespace Jina
{
    /// <summary>
    /// Generate embeddings and rerank documents using state-of-the-art models.<br/>
    /// **Embeddings** convert text, images, and documents into dense vector representations for semantic search, RAG, and similarity matching. Available models include `jina-embeddings-v3` (multilingual, 8K context), `jina-embeddings-v4` (multimodal, 32K context), `jina-embeddings-v5-text-small` (multilingual, 32K context, 1024-dim), `jina-embeddings-v5-text-nano` (multilingual, 8K context, 768-dim), and `jina-clip-v2` (text-image, 89 languages).<br/>
    /// **Reranking** refines search results by scoring query-document relevance. Models include `jina-reranker-v3` (0.6B, 131K context, listwise reranking), `jina-reranker-m0` (multimodal, 29 languages), `jina-reranker-v2-base-multilingual` (100+ languages, function calling support), and `jina-colbert-v2` (late interaction for high precision).<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ISearchFoundationModelsClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Jina.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


    }
}