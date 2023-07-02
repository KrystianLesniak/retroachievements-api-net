using System.Text;

namespace RetroAchievements.Api.Internal.Utils
{
    internal static class HttpClientExtensions
    {
        public static async Task<HttpResponseMessage> GetWithQueryStringAsync(this HttpClient client, string uri,
            IDictionary<string, string> queryStringParams)
        {
            var url = GetUriWithQueryString(uri, queryStringParams);

            return await client.GetAsync(url);
        }

        private static string GetUriWithQueryString(string requestUri,
                IDictionary<string, string> queryStringParams)
        {
            bool startingQuestionMarkAdded = false;
            var sb = new StringBuilder();
            sb.Append(requestUri);
            foreach (var parameter in queryStringParams)
            {
                if (parameter.Value == null)
                {
                    continue;
                }

                sb.Append(startingQuestionMarkAdded ? '&' : '?');
                sb.Append(parameter.Key);
                sb.Append('=');
                sb.Append(parameter.Value);
                startingQuestionMarkAdded = true;
            }
            return sb.ToString();
        }
    }
}
