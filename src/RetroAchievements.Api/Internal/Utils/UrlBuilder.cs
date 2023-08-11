using System.Text;

namespace RetroAchievements.Api.Internal.Utils
{
    internal static class UrlBuilder
    {
        private static readonly string baseUrl = "https://retroachievements.org/API/";

        public static string PrepareRequestUrlWithQuery(string requestEndpoint,
                IDictionary<string, string> queryStringParams)
        {
            return GetEndpointUrl(requestEndpoint) + GetQueries(queryStringParams);
        }

        private static string GetEndpointUrl(string requestEndpoint)
        {
            return string.Concat(baseUrl, requestEndpoint.Trim().Trim('/'), ".php");
        }

        private static string GetQueries(IDictionary<string, string> queryStringParams)
        {
            bool startingQuestionMarkAdded = false;
            var sb = new StringBuilder();
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
