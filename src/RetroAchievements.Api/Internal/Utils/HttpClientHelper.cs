using RetroAchievements.Api.Request;
using RetroAchievements.Api.Requests;
using RetroAchievements.Api.Response;
using System.Collections;
using System.Reflection;

namespace RetroAchievements.Api.Internal.Utils
{
    internal static class HttpClientHelper
    {
        private static readonly string baseUrl = "https://retroachievements.org/API/";

        public static string PrepareRequestUrl(string apiUrl)
        {
            return string.Concat(baseUrl, apiUrl.Trim().Trim('/'), ".php");
        }

        public static IDictionary<string, string> PrepareRequestQueries<TResponse>(IRetroAchievementsAuthenticationData auth, IRetroAchievementsRequest<TResponse> request) where TResponse : RetroAchievementsResponse, new()
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
                    var value = property.GetValue(request);
                    values.Add(attr.Key, GetMemberStringValue(property.PropertyType, value, attr.Option));
                }
            }

            return values;
        }

        private static string GetMemberStringValue(Type propertyType, object? propertyValue, CustomOption option)
        {
            if (propertyValue == null)
                return string.Empty;

            //Is DateTime
            if (propertyType == typeof(DateTime))
            {
                if (option == CustomOption.DateTimeToUnixSeconds)
                {
                    DateTimeOffset dto = new(((DateTime)propertyValue).ToUniversalTime());
                    return dto.ToUnixTimeSeconds().ToString();
                }
                else if (option == CustomOption.DateTimeToShortDate)
                {
                    return ((DateTime)propertyValue).ToString("yyyy-MM-dd");
                }

                return ((DateTime)propertyValue).ToString("yyyy-MM-dd HH:mm:ss");
            }
            //Is Enum
            else if (propertyType.IsEnum)
            {
                return ((int)propertyValue).ToString();

            }
            //Is IEnumerable
            else if (propertyType != typeof(string) && typeof(IEnumerable).IsAssignableFrom(propertyType))
            {
                var enumerable = (IEnumerable)propertyValue;

                var preparedPropList = new List<string>();
                foreach(var enumerableItem in enumerable)
                {
                    if (enumerableItem != null)
                        preparedPropList.Add(GetMemberStringValue(enumerableItem.GetType(), enumerableItem, option));
                }

                return string.Join(',', preparedPropList);
            }

            return propertyValue.ToString() ?? string.Empty;
        }
    }
}
