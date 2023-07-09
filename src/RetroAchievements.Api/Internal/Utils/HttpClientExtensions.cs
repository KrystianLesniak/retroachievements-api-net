using System.Text;

namespace RetroAchievements.Api.Internal.Utils
{
    internal static class HttpClientExtensions
    {
        public static async Task<HttpResponseMessage> GetWithQueryStringAsync(this HttpClient client, string uri, IDictionary<string, string> queryStringParams)
        {
            var url = GetUriWithQueryString(uri, queryStringParams);

            return await client.GetAsync(url);
        }

        public static HttpResponseMessage GetWithQueryString(this HttpClient client, string uri, IDictionary<string, string> queryStringParams)
        {
            var url = GetUriWithQueryString(uri, queryStringParams);

            return client.Send(new HttpRequestMessage(HttpMethod.Get, url));
        }

        private static string GetUriWithQueryString(string requestUri,
                IDictionary<string, string> queryStringParams)
        {
            bool startingQuestionMarkAdded = false;
            var sb = new StringBuilder();
            sb.Append(requestUri);
            foreach (var parameter in queryStringParams)
            {
                if (string.IsNullOrWhiteSpace(parameter.Value))
                {
                    continue;
                }

                sb.Append(startingQuestionMarkAdded ? '&' : '?');
                sb.Append(parameter.Key);
                sb.Append('=');
                sb.Append(parameter.Value.Replace(" ", "%20"));
                startingQuestionMarkAdded = true;
            }
            return sb.ToString();
        }
    }
}
