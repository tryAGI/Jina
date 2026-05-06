
#nullable enable

namespace Jina
{
    /// <summary>
    /// Best-in-class embeddings, rerankers, and classifiers. Search AI for multilingual and multimodal data.<br/>
    /// ## Capabilities<br/>
    /// - **Text Embeddings**: Dense vector representations for semantic search, similarity, and classification<br/>
    /// - **Multimodal Embeddings**: Process images, PDFs, and text in a unified vector space<br/>
    /// - **Reranking**: Refine search results with precise relevance scoring<br/>
    /// - **Classification**: Zero-shot and few-shot text classification<br/>
    /// - **Multi-vector Embeddings**: Token-level embeddings for ColBERT and late interaction<br/>
    /// - **Batch Embeddings**: Asynchronous bulk embedding processing via JSONL input/output<br/>
    /// ## Authentication<br/>
    /// Include your API key in the `Authorization` header:<br/>
    /// ```<br/>
    /// Authorization: Bearer jina_YOUR_API_KEY<br/>
    /// ```<br/>
    /// Get your API key at [jina.ai/api-dashboard/key-manager](https://jina.ai/api-dashboard/key-manager). New users receive **10M free tokens**.<br/>
    /// ## Rate Limits<br/>
    /// | Tier | RPM | TPM | Concurrency |<br/>
    /// |------|-----|-----|-------------|<br/>
    /// | Free | 500 | 1M | 5 |<br/>
    /// | Tier 1 | 500 | 10M | 50 |<br/>
    /// | Tier 2 | 5,000 | 100M | 500 |<br/>
    /// Rate limit headers are included in responses: `X-RateLimit-Remaining-Requests`, `X-RateLimit-Remaining-Tokens`.<br/>
    /// ## Error Codes<br/>
    /// All endpoints may return the following errors. Endpoint-specific errors are documented per operation.<br/>
    /// | Code | Status | Description |<br/>
    /// |------|--------|-------------|<br/>
    /// | `INPUT_MODEL_NOT_FOUND` | 400 | Model 'X' not found |<br/>
    /// | `INPUT_INVALID_LABELS` | 400 | Invalid training labels |<br/>
    /// | `INPUT_LABEL_LIMIT_EXCEEDED` | 400 | Label limit exceeded: {current} labels provided, maximum N allowed for your plan |<br/>
    /// | `AUTH_MISSING_API_KEY` | 401 | Authentication required |<br/>
    /// | `AUTH_INVALID_API_KEY` | 401 | Invalid API key |<br/>
    /// | `AUTH_INVALID_FORMAT` | 401 | Invalid authorization format |<br/>
    /// | `AUTHZ_INSUFFICIENT_BALANCE` | 403 | Insufficient account balance |<br/>
    /// | `AUTHZ_RESOURCE_LIMIT_EXCEEDED` | 403 | Resource limit exceeded for your plan |<br/>
    /// | `RESOURCE_NOT_FOUND` | 404 | {resource_type} '{resource_id}' not found or access denied |<br/>
    /// | `CONFLICT_RESOURCE_BUSY` | 409 | {resource_type} '{resource_id}' is currently being modified |<br/>
    /// | `RATE_REQUEST_LIMIT_EXCEEDED` | 429 | Request rate limit exceeded: {current}/N requests per minute |<br/>
    /// | `RATE_TOKEN_LIMIT_EXCEEDED` | 429 | Token rate limit exceeded: {current:,}/{limit:,} tokens per minute |<br/>
    /// | `RATE_CONCURRENCY_LIMIT_EXCEEDED` | 429 | Concurrency limit exceeded: {current}/N concurrent requests |<br/>
    /// | `RATE_IP_LIMIT_EXCEEDED` | 429 | IP rate limit exceeded |<br/>
    /// | `INTERNAL_ERROR` | 500 | An unexpected error occurred |<br/>
    /// | `SERVICE_UNAVAILABLE` | 503 | Service temporarily unavailable |<br/>
    /// | `SERVICE_TIMEOUT` | 504 | Request timed out after {timeout_seconds} seconds |<br/>
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
        /// Asynchronous batch embedding processing for large-scale workloads.<br/>
        /// Submit embedding jobs with up to 50,000 inputs via GCS file URL or up to 10,000 inputs inline. Jobs are processed asynchronously - poll for status, then download output as JSONL when complete.<br/>
        /// **Workflow**: 1) Submit job via `POST /v1/batch/embeddings` with input data and model selection. 2) Poll `GET /v1/batch/{batch_id}` until status is `completed`. 3) Download results from `GET /v1/batch/{batch_id}/output`.<br/>
        /// **Input format**: OpenAI-compatible JSONL with `custom_id` and `body.input` fields. Supports both inline JSON arrays and GCS-hosted JSONL files for larger batches.<br/>
        /// **Supported models**: `jina-embeddings-v5-text-small` (1024-dim, 32K context) and `jina-embeddings-v5-text-nano` (768-dim, 8K context). All task types supported: retrieval, text-matching, clustering, classification.<br/>
        /// Output files expire after 24 hours. Optional webhook notifications on job completion.
        /// </summary>
        public BatchEmbeddingsClient BatchEmbeddings { get; }

        /// <summary>
        /// Liveness and readiness probes for service health monitoring. For internal use only.
        /// </summary>
        public HealthCheckClient HealthCheck { get; }

        /// <summary>
        /// List available Jina AI models and their capabilities.<br/>
        /// Returns model metadata in OpenRouter-compatible format including model IDs, input/output modalities, context lengths, and pricing information. Use this endpoint to discover available models before making API calls.
        /// </summary>
        public ModelListClient ModelList { get; }

        /// <summary>
        /// Generate embeddings and rerank documents using state-of-the-art models.<br/>
        /// **Embeddings** convert text, images, and documents into dense vector representations for semantic search, RAG, and similarity matching. Available models include `jina-embeddings-v3` (multilingual, 8K context), `jina-embeddings-v4` (multimodal, 32K context), `jina-embeddings-v5-text-small` (multilingual, 32K context, 1024-dim), `jina-embeddings-v5-text-nano` (multilingual, 8K context, 768-dim), and `jina-clip-v2` (text-image, 89 languages).<br/>
        /// **Reranking** refines search results by scoring query-document relevance. Models include `jina-reranker-v3` (0.6B, 131K context, listwise reranking), `jina-reranker-m0` (multimodal, 29 languages), `jina-reranker-v2-base-multilingual` (100+ languages, function calling support), and `jina-colbert-v2` (late interaction for high precision).
        /// </summary>
        public SearchFoundationModelsClient SearchFoundationModels { get; }

        /// <summary>
        /// Categorize text and images using embedding-based classification.<br/>
        /// **Zero-shot**: Classify inputs into semantic labels without training data. Supports up to 256 classes. Best for flexible, immediate classification with descriptive labels.<br/>
        /// **Few-shot**: Train custom classifiers with labeled examples (200-400 samples recommended). Supports incremental updates and handles domain-specific or time-sensitive data. Limited to 16 classes and 16 classifiers per API key.<br/>
        /// Supports multilingual text via `jina-embeddings-v3`, `jina-embeddings-v5-text-small`, `jina-embeddings-v5-text-nano`, and multimodal (text/image) via `jina-clip-v2` or `jina-embeddings-v4`.
        /// </summary>
        public ZeroFewShotClassificationClient ZeroFewShotClassification { get; }

    }
}