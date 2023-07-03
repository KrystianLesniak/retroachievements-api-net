// See https://aka.ms/new-console-template for more information

using RetroAchievements.Api;
using RetroAchievements.Api.Requests.Users;
using RetroAchievements.Api.Users;

//var userName = "dsa";
//var webApiKey = "dsadas";

var authData = new RetroAchievementsAuthenticationData(userName, webApiKey);

using (var client = new RetroAchievementsHttpClient())
{
    var response = await client.GetAchievementCount(authData, new GetAchievementCountRequest(14402));
    var test = "";
};

