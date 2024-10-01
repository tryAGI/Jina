
#nullable enable

namespace Jina
{
    public sealed partial class JinaApi
    {
        /// <inheritdoc cref="JinaApi(global::System.Net.Http.HttpClient?, global::System.Uri?, global::Jina.EndPointAuthorization?)"/>
        public JinaApi(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::Jina.EndPointAuthorization? authorization = null) : this(httpClient, baseUri, authorization)
        {
            Authorizing(_httpClient, ref apiKey);

            AuthorizeUsingBearer(apiKey);

            Authorized(_httpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}