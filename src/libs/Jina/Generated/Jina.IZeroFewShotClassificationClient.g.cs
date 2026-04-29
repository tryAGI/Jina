
#nullable enable

namespace Jina
{
    /// <summary>
    /// Categorize text and images using embedding-based classification.<br/>
    /// **Zero-shot**: Classify inputs into semantic labels without training data. Supports up to 256 classes. Best for flexible, immediate classification with descriptive labels.<br/>
    /// **Few-shot**: Train custom classifiers with labeled examples (200-400 samples recommended). Supports incremental updates and handles domain-specific or time-sensitive data. Limited to 16 classes and 16 classifiers per API key.<br/>
    /// Supports multilingual text via `jina-embeddings-v3`, `jina-embeddings-v5-text-small`, `jina-embeddings-v5-text-nano`, and multimodal (text/image) via `jina-clip-v2` or `jina-embeddings-v4`.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IZeroFewShotClassificationClient : global::System.IDisposable
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