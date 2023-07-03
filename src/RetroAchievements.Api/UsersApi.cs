using RetroAchievements.Api.Requests.Users;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api
{
    public static class UsersApi
    {
        public static async Task<GetAchievementCountResponse> GetAchievementCount(this RetroAchievementsHttpClient client, int gameId, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.GetAchievementCount(new GetAchievementCountRequest(gameId), authenticationData);
        }

        public static async Task<GetAchievementCountResponse> GetAchievementCount(this RetroAchievementsHttpClient client, GetAchievementCountRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            var response = await client.HandleRequestCall(request, authenticationData);
            return new GetAchievementCountResponse(response.Item1, response.Item2);
        }
    }
}
