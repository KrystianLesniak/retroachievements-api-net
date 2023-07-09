﻿using RetroAchievements.Api.Request;
using RetroAchievements.Api.Requests;
using System;
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

        public static IDictionary<string, string> PrepareRequestQueries(IRetroAchievementsAuthenticationData auth, IRetroAchievementsRequest request)
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
                    values.Add(attr.Key, GetMemberStringValue(property, value, attr.Option));
                }
            }

            return values;
        }

        private static string GetMemberStringValue(PropertyInfo p, object? propertyValue, CustomOption option)
        {
            if (propertyValue == null)
                return string.Empty;

            //Is DateTime
            if (p.PropertyType == typeof(DateTime))
            {
                if(option == CustomOption.DateTimeToUnixSeconds)
                {
                    DateTimeOffset dto = new(((DateTime)propertyValue).ToUniversalTime());
                    return dto.ToUnixTimeSeconds().ToString();
                }
                else if(option == CustomOption.DateTimeToShortDate)
                {
                    return ((DateTime)propertyValue).ToString("yyyy-MM-dd");
                }

                return ((DateTime)propertyValue).ToString("yyyy-MM-dd HH:mm:ss");
            }
            //Is Enum
            else if (p.PropertyType.IsEnum)
            {
                return ((int)propertyValue).ToString();

            }
            //Is IEnumerable
            else if(p.PropertyType != typeof(string) && typeof(IEnumerable).IsAssignableFrom(p.PropertyType))
            {
                var prop = (IEnumerable<object?>)propertyValue;
                //TODO: Add support for CSV: collect(explode(',', $gameCSV))

            }

            return propertyValue.ToString() ?? string.Empty;
        }
    }
}