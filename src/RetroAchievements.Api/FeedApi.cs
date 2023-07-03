using RetroAchievements.Api.Requests.Users;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api
{
    public static class FeedApi
    {
        public static async Task<GetAchievementOfTheWeekResponse> GetAchievementOfTheWeek(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.GetAchievementOfTheWeek(new GetAchievementOfTheWeekRequest(), authenticationData);
        }

        public static async Task<GetAchievementOfTheWeekResponse> GetAchievementOfTheWeek(this RetroAchievementsHttpClient client, GetAchievementOfTheWeekRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            var response = await client.HandleRequestCall(request, authenticationData);
            return new GetAchievementOfTheWeekResponse(response.Item1, response.Item2);
        }
    }
}
