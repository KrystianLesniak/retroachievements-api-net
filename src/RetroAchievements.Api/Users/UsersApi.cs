using RetroAchievements.Api.Requests.Users;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Users
{
    public static class UsersApi
    {
        public static async Task<GetAchievementCountResponse> GetAchievementCount(this RetroAchievementsHttpClient client, int gameId, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await GetAchievementCount(client, new GetAchievementCountRequest(gameId), authenticationData);
        }

        public static async Task<GetAchievementCountResponse> GetAchievementCount(this RetroAchievementsHttpClient client, GetAchievementCountRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            var response = await client.HandleRequestCall(request, authenticationData);
            return new GetAchievementCountResponse(await response.Content.ReadAsStringAsync(), response.StatusCode);
        }
    }
}
