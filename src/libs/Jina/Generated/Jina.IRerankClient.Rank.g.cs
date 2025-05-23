#nullable enable

namespace Jina
{
    public partial interface IRerankClient
    {
        /// <summary>
        /// Rank<br/>
        /// Rank pairs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Jina.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.RankingOutput> RankAsync(
            global::Jina.RankAPIInput request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Rank<br/>
        /// Rank pairs.
        /// </summary>
        /// <param name="model">
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-reranker-m0`,	2B<br/>
        /// - `jina-reranker-v2-base-multilingual`,	278M<br/>
        /// - `jina-reranker-v1-base-en`,	137M<br/>
        /// - `jina-reranker-v1-tiny-en`,	33M<br/>
        /// - `jina-reranker-v1-turbo-en`,	38M<br/>
        /// - `jina-colbert-v1-en`,	137M
        /// </param>
        /// <param name="query">
        /// The search query
        /// </param>
        /// <param name="documents">
        /// A list of text documents, image documents or strings to rerank. If a document is provided the text or image fields are required and all other fields will be preserved in the response.
        /// </param>
        /// <param name="topN">
        /// The number of most relevant documents or indices to return, defaults to the length of `documents`
        /// </param>
        /// <param name="returnDocuments">
        /// If false, returns results without the doc text - the api will return a list of {index, relevance score} where index is inferred from the list passed into the request. If true, returns results with the doc text passed in - the api will return an ordered list of {index, text, relevance score} where index + text refers to the list passed into the request. Defaults to true<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Jina.RankingOutput> RankAsync(
            string model,
            global::Jina.AnyOf<string, global::Jina.ApiSchemasRankTextDoc, global::Jina.ApiSchemasImageImageDoc> query,
            global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.ApiSchemasImageImageDoc, global::Jina.ApiSchemasRankTextDoc, string, global::Jina.TextOrImageDoc>> documents,
            int? topN = default,
            bool? returnDocuments = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}