
#nullable enable

namespace Jina
{
    public partial interface IZeroFewShotClassificationClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}