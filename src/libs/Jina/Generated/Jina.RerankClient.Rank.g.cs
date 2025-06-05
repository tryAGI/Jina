
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
        /// <exception cref="global::Jina.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Jina.RankingOutput> RankAsync(
            global::Jina.RankAPIInput request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRankArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Jina.PathBuilder(
                path: "/v1/rerank",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareRankRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRankResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::Jina.HTTPValidationError? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::Jina.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::Jina.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Jina.ApiException<global::Jina.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessRankResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Jina.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::Jina.RankingOutput.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Jina.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return
                    await global::Jina.RankingOutput.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

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
        public async global::System.Threading.Tasks.Task<global::Jina.RankingOutput> RankAsync(
            string model,
            global::Jina.AnyOf<string, global::Jina.ApiSchemasRankTextDoc, global::Jina.ApiSchemasImageImageDoc> query,
            global::System.Collections.Generic.IList<global::Jina.AnyOf<global::Jina.ApiSchemasImageImageDoc, global::Jina.ApiSchemasRankTextDoc, string, global::Jina.TextOrImageDoc>> documents,
            int? topN = default,
            bool? returnDocuments = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Jina.RankAPIInput
            {
                Model = model,
                Query = query,
                Documents = documents,
                TopN = topN,
                ReturnDocuments = returnDocuments,
            };

            return await RankAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}