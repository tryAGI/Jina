
#nullable enable

namespace Jina
{
    /// <summary>
    /// This is the UniversalAPI to access all the Jina embedding models<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IJinaApi : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsClient Embeddings { get; }

        /// <summary>
        /// 
        /// </summary>
        public BulkEmbeddingsClient BulkEmbeddings { get; }

        /// <summary>
        /// 
        /// </summary>
        public RerankClient Rerank { get; }

        /// <summary>
        /// 
        /// </summary>
        public MultiVectorClient MultiVector { get; }

    }
}