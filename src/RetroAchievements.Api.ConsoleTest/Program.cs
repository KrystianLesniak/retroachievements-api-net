// See https://aka.ms/new-console-template for more information

using RetroAchievements.Api;
using RetroAchievements.Api.Requests.Users;
using RetroAchievements.Api.Users;

var userName = "";
var webApiKey = "";

var authData = new RetroAchievementsAuthenticationData(userName, webApiKey);

using (var client = new RetroAchievementsClient())
{
    var response = await client.GetAchievementsEarnedBetween(authData, new GetAchievementsEarnedBetweenRequest("14402"));
    var test = "";
};

