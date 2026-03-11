
#nullable enable

namespace Jina
{
    /// <summary>
    /// Asynchronous batch embedding processing for large-scale workloads.<br/>
    /// Submit embedding jobs with up to 50,000 inputs via GCS file URL or up to 10,000 inputs inline. Jobs are processed asynchronously - poll for status, then download output as JSONL when complete.<br/>
    /// **Workflow**: 1) Submit job via `POST /v1/batch/embeddings` with input data and model selection. 2) Poll `GET /v1/batch/{batch_id}` until status is `completed`. 3) Download results from `GET /v1/batch/{batch_id}/output`.<br/>
    /// **Input format**: OpenAI-compatible JSONL with `custom_id` and `body.input` fields. Supports both inline JSON arrays and GCS-hosted JSONL files for larger batches.<br/>
    /// **Supported models**: `jina-embeddings-v5-text-small` (1024-dim, 32K context) and `jina-embeddings-v5-text-nano` (768-dim, 8K context). All task types supported: retrieval, text-matching, clustering, classification.<br/>
    /// Output files expire after 24 hours. Optional webhook notifications on job completion.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class BatchEmbeddingsClient : global::Jina.IBatchEmbeddingsClient, global::System.IDisposable
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
        /// Creates a new instance of the BatchEmbeddingsClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public BatchEmbeddingsClient(
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