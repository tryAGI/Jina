
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
    public partial interface IBatchEmbeddingsClient : global::System.IDisposable
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