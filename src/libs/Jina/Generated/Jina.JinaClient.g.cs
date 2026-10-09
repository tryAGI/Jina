
#nullable enable

namespace Jina
{
    /// <summary>
    /// Best-in-class embeddings, rerankers and document models for multilingual and multimodal search.<br/>
    /// ## Capabilities<br/>
    /// - **Text embeddings** — dense vectors for semantic search, similarity, clustering and classification, in 100+ languages.<br/>
    /// - **Multimodal embeddings** — images, video, audio and PDFs embedded into the same space as text, so a query in one modality retrieves another.<br/>
    /// - **Reranking** — score a query against a candidate set and reorder it; more accurate than embedding similarity, and the usual second stage after it.<br/>
    /// - **Document OCR** — read a page image and return its content as text or markdown, with tables and layout preserved, over the OpenAI chat completions schema.<br/>
    /// - **Batch embeddings** — the same embedding models over JSONL, asynchronously, for workloads too large to send inline.<br/>
    /// ## Authentication<br/>
    /// Every endpoint except `GET /v1/models` requires a key:<br/>
    /// ```<br/>
    /// Authorization: Bearer jina_YOUR_API_KEY<br/>
    /// ```<br/>
    /// Get one at [jina.ai/api-dashboard/key-manager](https://jina.ai/api-dashboard/key-manager).<br/>
    /// ## Rate limits<br/>
    /// Requests per minute and tokens per minute. Anything over a limit answers `429`.<br/>
    /// | Endpoint | Free | Paid | Premium |<br/>
    /// |---|---|---|---|<br/>
    /// | `/v1/embeddings` | 500 RPM · 1M TPM | 500 RPM · 10M TPM | 5,000 RPM · 100M TPM |<br/>
    /// | `/v1/rerank` | 500 RPM · 1M TPM | 500 RPM · 10M TPM | 5,000 RPM · 100M TPM |<br/>
    /// | `/v1/chat/completions` | 100 RPM · 500K TPM | 100 RPM · 5M TPM | 1,000 RPM · 50M TPM |<br/>
    /// ## Errors<br/>
    /// Failures carry a `detail`, a `code` from the table below and the `request_id` to quote in a support request. `/v1/chat/completions` is the exception: it answers in OpenAI's error envelope, with the same code inside it.<br/>
    /// | Code | Status | Meaning |<br/>
    /// |---|---|---|<br/>
    /// | `INPUT_INVALID_LABELS` | 400 | Invalid training labels |<br/>
    /// | `INPUT_LABEL_LIMIT_EXCEEDED` | 400 | Label limit exceeded: &lt;current&gt; labels provided, maximum &lt;limit&gt; allowed for your plan |<br/>
    /// | `INPUT_MODEL_NOT_FOUND` | 400 | Model '&lt;model&gt;' not found |<br/>
    /// | `INPUT_TOKEN_LIMIT_EXCEEDED` | 400 | Input text exceeds the model's maximum of &lt;max_tokens&gt; tokens |<br/>
    /// | `AUTH_INVALID_API_KEY` | 401 | Invalid API key |<br/>
    /// | `AUTH_INVALID_FORMAT` | 401 | Invalid authorization format |<br/>
    /// | `AUTH_MISSING_API_KEY` | 401 | Authentication required |<br/>
    /// | `AUTHZ_INSUFFICIENT_BALANCE` | 403 | Insufficient account balance |<br/>
    /// | `AUTHZ_RESOURCE_LIMIT_EXCEEDED` | 403 | Resource limit exceeded for your plan |<br/>
    /// | `RESOURCE_NOT_FOUND` | 404 | &lt;resource_type&gt; '&lt;resource_id&gt;' not found or access denied |<br/>
    /// | `CONFLICT_RESOURCE_BUSY` | 409 | &lt;resource_type&gt; '&lt;resource_id&gt;' is currently being modified |<br/>
    /// | `RATE_CONCURRENCY_LIMIT_EXCEEDED` | 429 | Concurrency limit exceeded: &lt;current&gt;/&lt;limit&gt; concurrent requests |<br/>
    /// | `RATE_IP_LIMIT_EXCEEDED` | 429 | IP rate limit exceeded |<br/>
    /// | `RATE_REQUEST_LIMIT_EXCEEDED` | 429 | Request rate limit exceeded: &lt;current&gt;/&lt;limit&gt; requests per minute |<br/>
    /// | `RATE_TOKEN_LIMIT_EXCEEDED` | 429 | Token rate limit exceeded: &lt;current&gt;/&lt;limit&gt; tokens per minute |<br/>
    /// | `INTERNAL_ERROR` | 500 | An unexpected error occurred |<br/>
    /// | `SERVICE_UNAVAILABLE` | 503 | Service temporarily unavailable |<br/>
    /// | `SERVICE_TIMEOUT` | 504 | Service request timed out |<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class JinaClient : global::Jina.IJinaClient, global::System.IDisposable
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

        /// <inheritdoc/>
        public global::Jina.AutoSDKClientOptions Options { get; }

        internal global::System.Lazy<global::System.Text.Json.Serialization.JsonSerializerContext> JsonSerializerContextProvider { get; set; } = new(() => global::Jina.SourceGenerationContext.Default);

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext
        {
            get => JsonSerializerContextProvider.Value;
            set => JsonSerializerContextProvider = new(() => value);
        }


        /// <summary>
        /// Asynchronous embedding for large workloads: up to 50,000 inputs from a GCS file URL, or 10,000 inline.<br/>
        /// Submit with `POST /v1/batch/embeddings`, poll `GET /v1/batch/{batch_id}` until the status is `completed`, then fetch `GET /v1/batch/{batch_id}/output`. Input is OpenAI-compatible JSONL with `custom_id` and `body.input`. Output files expire after 24 hours, and a webhook can be called on completion.
        /// </summary>
        public BatchEmbeddingsClient BatchEmbeddings => new BatchEmbeddingsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Document transcription over the OpenAI chat completions schema. Point any OpenAI-compatible client at the server URL above with `/v1` appended, set `model`, and send a page image; the response is the page as text or markdown, tables and layout preserved.<br/>
        /// `stream: true` returns server-sent events. `response_format` with a `json_schema` constrains the output to that schema instead of prose. Parameters outside the supported set are accepted and ignored rather than rejected, so an SDK-generated payload always works.
        /// </summary>
        public GenerativeModelsClient GenerativeModels => new GenerativeModelsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Every model this API serves, in OpenRouter-compatible form: identifiers, input and output modalities, context lengths and prices. Read it before hardcoding a model name — the catalogue moves.
        /// </summary>
        public ModelListClient ModelList => new ModelListClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// **Embeddings** turn text, images, audio, video and PDFs into dense vectors for semantic search, RAG, clustering and classification. Task-specific variants (`retrieval.query`, `retrieval.passage`, `text-matching`, `clustering`, `classification`) are selected per request rather than per model, and `dimensions` truncates the output where a model supports it.<br/>
        /// **Reranking** scores a query against a candidate set and returns it reordered, which is more accurate than embedding similarity and slower — the usual shape is embeddings to retrieve, reranking to refine.<br/>
        /// Each endpoint's `model` field lists the models it accepts.
        /// </summary>
        public SearchFoundationModelsClient SearchFoundationModels => new SearchFoundationModelsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Creates a new instance of the JinaClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public JinaClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Jina.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the JinaClient with explicit options but no base URL override.
        /// Skips passing <c>baseUri</c> so the default base URL from the OpenAPI spec applies.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public JinaClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Collections.Generic.List<global::Jina.EndPointAuthorization>? authorizations,
            global::Jina.AutoSDKClientOptions? options,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri: null,
                authorizations,
                options,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the JinaClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public JinaClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Uri? baseUri,
            global::System.Collections.Generic.List<global::Jina.EndPointAuthorization>? authorizations,
            global::Jina.AutoSDKClientOptions? options,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Jina.EndPointAuthorization>();
            Options = options ?? new global::Jina.AutoSDKClientOptions();
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