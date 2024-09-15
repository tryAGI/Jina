
#nullable enable

namespace Jina
{
    public partial class BulkEmbeddingsClient
    {
        partial void PrepareStartBulkEmbeddingArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Jina.BodyStartBulkEmbeddingV1BulkEmbeddingsPost request);
        partial void PrepareStartBulkEmbeddingRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Jina.BodyStartBulkEmbeddingV1BulkEmbeddingsPost request);
        partial void ProcessStartBulkEmbeddingResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStartBulkEmbeddingResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Start Bulk Embedding<br/>
        /// Upload a file and get embeddings for each row
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Jina.BulkEmbeddingJobResponse> StartBulkEmbeddingAsync(
            global::Jina.BodyStartBulkEmbeddingV1BulkEmbeddingsPost request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareStartBulkEmbeddingArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/v1/bulk-embeddings", global::System.UriKind.RelativeOrAbsolute));
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>())
                {
                    Headers =
                    {
                        ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                    },
                },
                name: "file",
                fileName: request.Filename ?? string.Empty);
            if (request.Email != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Email}"),
                    name: "email");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Model}"),
                name: "model");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareStartBulkEmbeddingRequest(
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
            ProcessStartBulkEmbeddingResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessStartBulkEmbeddingResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Jina.BulkEmbeddingJobResponse), JsonSerializerContext) as global::Jina.BulkEmbeddingJobResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Start Bulk Embedding<br/>
        /// Upload a file and get embeddings for each row
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="email"></param>
        /// <param name="model"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Jina.BulkEmbeddingJobResponse> StartBulkEmbeddingAsync(
            byte[] file,
            string filename,
            string model,
            string? email = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Jina.BodyStartBulkEmbeddingV1BulkEmbeddingsPost
            {
                File = file,
                Filename = filename,
                Email = email,
                Model = model,
            };

            return await StartBulkEmbeddingAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}