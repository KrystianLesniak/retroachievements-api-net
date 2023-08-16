using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace RetroAchievements.Api.Tests.Common
{
    public static class TestAuthenticationData
    {
        private static readonly IConfigurationRoot Configuration = new ConfigurationBuilder()
                 .AddJsonFile($"appsettings.json", optional: true)
                 .AddUserSecrets(Assembly.GetExecutingAssembly(), optional: true)
                 .Build();

        public static IRetroAchievementsAuthenticationData CreateFromSecrets()
        {
            var userName = Configuration["Username"];
            var webApiKey = Configuration["WebApiKey"];

            return new RetroAchievementsAuthenticationData(userName ?? string.Empty, webApiKey ?? string.Empty);
        }
    }
}