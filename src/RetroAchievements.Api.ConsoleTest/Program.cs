// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.Configuration;
using RetroAchievements.Api;
using RetroAchievements.Api.Response;
using System.Diagnostics;

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

    var responseList = new List<IRetroAchievementResponse>();

    Stopwatch stopWatch = new Stopwatch();

    //for (int i = 0; i < 100; i++)
    //{
    //    stopWatch.Start();
    //    responseList.Add( await client.GetAchievementOfTheWeek());

    //    stopWatch.Stop();

    //    Console.WriteLine($"Time: {stopWatch.Elapsed}");

    //    stopWatch.Reset();

    //    await Task.Delay(500);

    //}
    var response = await client.GetClaimsAsync();
};