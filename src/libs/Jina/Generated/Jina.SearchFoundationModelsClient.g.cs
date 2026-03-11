
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
    public sealed partial class SearchFoundationModelsClient : global::Jina.ISearchFoundationModelsClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.jina.ai/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Jina.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Jina.SourceGenerationContext.Default;


        /// <summary>
        /// Creates a new instance of the SearchFoundationModelsClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public SearchFoundationModelsClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Jina.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Jina.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}