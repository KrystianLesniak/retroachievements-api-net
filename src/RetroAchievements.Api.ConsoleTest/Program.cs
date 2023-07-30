// See https://aka.ms/new-console-template for more information

using RetroAchievements.Api;
using RetroAchievements.Api.Response;
using RetroAchievements.Api.Tests.Common;
using System.Diagnostics;


var authData = TestAuthenticationData.CreateFromSecrets();


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
    var response = await client.GetGameTicketDataAsync(4106);
};