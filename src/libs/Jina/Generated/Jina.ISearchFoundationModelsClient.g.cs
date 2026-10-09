
#nullable enable

namespace Jina
{
    /// <summary>
    /// **Embeddings** turn text, images, audio, video and PDFs into dense vectors for semantic search, RAG, clustering and classification. Task-specific variants (`retrieval.query`, `retrieval.passage`, `text-matching`, `clustering`, `classification`) are selected per request rather than per model, and `dimensions` truncates the output where a model supports it.<br/>
    /// **Reranking** scores a query against a candidate set and returns it reordered, which is more accurate than embedding similarity and slower — the usual shape is embeddings to retrieve, reranking to refine.<br/>
    /// Each endpoint's `model` field lists the models it accepts.<br/>
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
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Jina.AutoSDKClientOptions Options { get; }


        /// <summary>
        ///
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


    }
}