using Microsoft.Extensions.Configuration;

namespace RetroAchievements.Api.Tests.Common
{
    public static class TestAuthenticationData
    {
        private static readonly IConfigurationRoot Configuration = new ConfigurationBuilder()
                 .AddJsonFile(Path.GetFullPath($"../../../../../secrets.json"), optional: true)
                 .Build();

        public static IRetroAchievementsAuthenticationData Create()
        {
            var userName = Configuration["Username"];
            var webApiKey = Configuration["WebApiKey"];

            if (string.IsNullOrWhiteSpace(userName))
                throw new ArgumentNullException(userName, nameof(userName));

            if (string.IsNullOrWhiteSpace(webApiKey))
                throw new ArgumentNullException(webApiKey, nameof(webApiKey));


            return new RetroAchievementsAuthenticationData(userName, webApiKey);
        }
    }
}