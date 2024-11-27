
#nullable enable

namespace Jina
{
    public partial interface IJinaApi
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingBearer(
            string apiKey);
    }
}