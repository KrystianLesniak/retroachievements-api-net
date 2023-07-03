// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.Configuration;
using RetroAchievements.Api;

var configuration = new ConfigurationBuilder()
     .AddJsonFile($"appsettings.json")
     .AddJsonFile($"appsettings.secrets.json", optional: true)
     .Build();

var userName = configuration["Username"];
var webApiKey = configuration["WebApiKey"];

if (string.IsNullOrWhiteSpace(userName))
    throw new ArgumentNullException(userName, nameof(userName));

if (string.IsNullOrWhiteSpace(webApiKey))
    throw new ArgumentNullException(webApiKey, nameof(webApiKey));


var authData = new RetroAchievementsAuthenticationData(userName, webApiKey);

using (var client = new RetroAchievementsHttpClient(authData))
{
    var response = await client.GetAchievementOfTheWeek();
};

