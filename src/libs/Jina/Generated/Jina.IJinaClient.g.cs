
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
    public partial interface IJinaClient : global::System.IDisposable
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


        /// <summary>
        /// Asynchronous embedding for large workloads: up to 50,000 inputs from a GCS file URL, or 10,000 inline.<br/>
        /// Submit with `POST /v1/batch/embeddings`, poll `GET /v1/batch/{batch_id}` until the status is `completed`, then fetch `GET /v1/batch/{batch_id}/output`. Input is OpenAI-compatible JSONL with `custom_id` and `body.input`. Output files expire after 24 hours, and a webhook can be called on completion.
        /// </summary>
        public BatchEmbeddingsClient BatchEmbeddings { get; }

        /// <summary>
        /// Document transcription over the OpenAI chat completions schema. Point any OpenAI-compatible client at the server URL above with `/v1` appended, set `model`, and send a page image; the response is the page as text or markdown, tables and layout preserved.<br/>
        /// `stream: true` returns server-sent events. `response_format` with a `json_schema` constrains the output to that schema instead of prose. Parameters outside the supported set are accepted and ignored rather than rejected, so an SDK-generated payload always works.
        /// </summary>
        public GenerativeModelsClient GenerativeModels { get; }

        /// <summary>
        /// Every model this API serves, in OpenRouter-compatible form: identifiers, input and output modalities, context lengths and prices. Read it before hardcoding a model name — the catalogue moves.
        /// </summary>
        public ModelListClient ModelList { get; }

        /// <summary>
        /// **Embeddings** turn text, images, audio, video and PDFs into dense vectors for semantic search, RAG, clustering and classification. Task-specific variants (`retrieval.query`, `retrieval.passage`, `text-matching`, `clustering`, `classification`) are selected per request rather than per model, and `dimensions` truncates the output where a model supports it.<br/>
        /// **Reranking** scores a query against a candidate set and returns it reordered, which is more accurate than embedding similarity and slower — the usual shape is embeddings to retrieve, reranking to refine.<br/>
        /// Each endpoint's `model` field lists the models it accepts.
        /// </summary>
        public SearchFoundationModelsClient SearchFoundationModels { get; }

    }
}