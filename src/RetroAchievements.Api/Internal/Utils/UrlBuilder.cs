using RetroAchievements.Api.Request;
using RetroAchievements.Api.Requests;
using System.Reflection;

namespace RetroAchievements.Api.Internal.Utils
{
    internal static class UrlBuilder
    {
        private static readonly string baseUrl = "https://retroachievements.org/API/";

        public static Task<string> PrepareRequestUrl(string apiUrl)
        {
            return Task.FromResult(string.Concat(baseUrl, apiUrl.Trim().Trim('/'), ".php"));
        }

        public static Task<IDictionary<string, string>> PrepareRequestQueries(IRetroAchievementsAuthenticationData auth, IRequest request)
        {
            var values = new Dictionary<string, string>()
            {
                ["z"] = auth.UserName,
                ["y"] = auth.WebApiKey
            };

            var properties = request.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo property in properties)
            {
                var attr = property.GetCustomAttribute<ApiInputKeyAttribute>(true);

                if (attr != null)
                {
                    values.Add(attr.Key, GetMemberStringValue(property, request));
                }
            }

            return Task.FromResult(values as IDictionary<string, string>);
        }

        private static string GetMemberStringValue(PropertyInfo propertyInfo, IRequest requestObject)
        {
            var value = propertyInfo.GetValue(requestObject);
            if (value == null)
                return string.Empty;

            if (propertyInfo.PropertyType == typeof(DateTime))
            {
                return ((DateTime)value).ToString("Y-m-d H:i:s");
            }

            return value.ToString() ?? string.Empty;
        }
    }
}
