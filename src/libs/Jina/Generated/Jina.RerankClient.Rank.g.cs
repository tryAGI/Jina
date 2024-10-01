
#nullable enable

namespace Jina
{
    public partial class RerankClient
    {
        partial void PrepareRankArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Jina.RankAPIInput request);
        partial void PrepareRankRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Jina.RankAPIInput request);
        partial void ProcessRankResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRankResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Rank<br/>
        /// Rank pairs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Jina.RankingOutput> RankAsync(
            global::Jina.RankAPIInput request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareRankArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/rerank",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (_authorization != null)
            {{
                httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                    scheme: _authorization.Name,
                    parameter: _authorization.Value);
            }}
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareRankRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessRankResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessRankResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Jina.RankingOutput), JsonSerializerContext) as global::Jina.RankingOutput ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Rank<br/>
        /// Rank pairs.
        /// </summary>
        /// <param name="model">
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
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
        /// A list of text documents or strings to rerank. If a document is provided the text fields is required and all other fields will be preserved in the response.
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
        public async global::System.Threading.Tasks.Task<global::Jina.RankingOutput> RankAsync(
            string model,
            global::Jina.AnyOf<string, global::Jina.ApiSchemasRankTextDoc> query,
            global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::Jina.ApiSchemasRankTextDoc>> documents,
            int? topN = default,
            bool? returnDocuments = true,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Jina.RankAPIInput
            {
                Model = model,
                Query = query,
                Documents = documents,
                TopN = topN,
                ReturnDocuments = returnDocuments,
            };

            return await RankAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}