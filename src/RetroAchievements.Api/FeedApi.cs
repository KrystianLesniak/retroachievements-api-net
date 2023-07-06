using RetroAchievements.Api.Requests.Users;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api
{
    public static class FeedApi
    {
        #region GetAchievementOfTheWeek
        public static async Task<GetAchievementOfTheWeekResponse> GetAchievementOfTheWeekAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.GetAchievementOfTheWeekAsync(new GetAchievementOfTheWeekRequest(), authenticationData);
        }

        public static async Task<GetAchievementOfTheWeekResponse> GetAchievementOfTheWeekAsync(this RetroAchievementsHttpClient client, GetAchievementOfTheWeekRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.HandleRequestCallAsync<GetAchievementOfTheWeekResponse>(request, authenticationData);
        }

        public static GetAchievementOfTheWeekResponse GetAchievementOfTheWeek(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.GetAchievementOfTheWeek(new GetAchievementOfTheWeekRequest(), authenticationData);
        }

        public static GetAchievementOfTheWeekResponse GetAchievementOfTheWeek(this RetroAchievementsHttpClient client, GetAchievementOfTheWeekRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.HandleRequestCall<GetAchievementOfTheWeekResponse>(request, authenticationData);
        }
        #endregion GetAchievementOfTheWeek

    }
}
