namespace RetroAchievements.Api.Internal.Utils
{
    internal static class UrlBuilder
    {
        private static readonly string baseUrl = "https://retroachievements.org/API/";

        public static Task<string> PrepareRequestUrl(string apiUrl)
        {
            return Task.FromResult(string.Concat(baseUrl, apiUrl.Trim().Trim('/')));
        }

        public static Task<IDictionary<string, string>> PrepareRequestQueries(RetroAchievementsAuthenticationData auth, params KeyValuePair<string, string>[] parameters)
        {
            var values = new Dictionary<string, string>()
            {
                ["z"] = auth.UserName,
                ["y"] = auth.WebApiKey
            };

            foreach (var param in parameters)
            {
                values.Add(param.Key, param.Value);
            }

            return Task.FromResult(values as IDictionary<string, string>);
        }
    }
}
