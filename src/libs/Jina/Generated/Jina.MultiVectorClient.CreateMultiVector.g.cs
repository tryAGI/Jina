
#nullable enable

namespace Jina
{
    public partial class MultiVectorClient
    {
        partial void PrepareCreateMultiVectorArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Jina.TextEmbeddingAPIInput request);
        partial void PrepareCreateMultiVectorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Jina.TextEmbeddingAPIInput request);
        partial void ProcessCreateMultiVectorResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateMultiVectorResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Multi Vector<br/>
        /// Create multiple vector representations of the given input texts. One vector representation for each token in the input text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Jina.ColbertModelEmbeddingsOutput> CreateMultiVectorAsync(
            global::Jina.TextEmbeddingAPIInput request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateMultiVectorArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/multi-vector",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateMultiVectorRequest(
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
            ProcessCreateMultiVectorResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateMultiVectorResponseContent(
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
                global::Jina.ColbertModelEmbeddingsOutput.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Multi Vector<br/>
        /// Create multiple vector representations of the given input texts. One vector representation for each token in the input text.
        /// </summary>
        /// <param name="model">
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-colbert-v1-en`,	137
        /// </param>
        /// <param name="input">
        /// List of texts to embed
        /// </param>
        /// <param name="inputType">
        /// Type of the embedding to compute, query or document<br/>
        /// Default Value: document
        /// </param>
        /// <param name="embeddingType">
        /// The format in which you want the embeddings to be returned.Possible value are `float`, `base64`, `binary`, `ubinary` or a list containing any of them. Defaults to `float`
        /// </param>
        /// <param name="dimensions">
        /// Dimensions of the vectors to be returned. Only valid for v2 colbert models. Defaults to 128
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Jina.ColbertModelEmbeddingsOutput> CreateMultiVectorAsync(
            string model,
            global::Jina.AnyOf<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.IList<global::Jina.ApiSchemasEmbeddingTextDoc>, global::Jina.ApiSchemasEmbeddingTextDoc> input,
            global::Jina.TextEmbeddingAPIInputInputType? inputType = global::Jina.TextEmbeddingAPIInputInputType.Document,
            global::Jina.AnyOf<global::Jina.TextEmbeddingAPIInputEmbeddingType?, global::System.Collections.Generic.IList<global::Jina.TextEmbeddingAPIInputEmbeddingTypeItem>>? embeddingType = default,
            int? dimensions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Jina.TextEmbeddingAPIInput
            {
                Model = model,
                Input = input,
                InputType = inputType,
                EmbeddingType = embeddingType,
                Dimensions = dimensions,
            };

            return await CreateMultiVectorAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}