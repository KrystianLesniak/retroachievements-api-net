
using RetroAchievements.Api.Requests.Achievements;
using RetroAchievements.Api.Response.Achievements;

namespace RetroAchievements.Api
{
    /// <summary>
    /// Class with extension methods for calling APIs from group "Achievements"
    /// </summary>
    public static class AchievementsApi
    {
        #region GetAchievementUnlocks
        /// <inheritdoc cref="GetAchievementUnlocksRequest(int, int, int)"/>
        public static async Task<GetAchievementUnlocksResponse> GetAchievementUnlocksAsync(this IRetroAchievementsHttpClient client, int achievementId, int offset = 0, int count = 50, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetAchievementUnlocksRequest(achievementId, offset, count), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetAchievementUnlocksRequest(int, int, int)"/>
        public static GetAchievementUnlocksResponse GetAchievementUnlocks(this IRetroAchievementsHttpClient client, int achievementId, int offset = 0, int count = 50, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetAchievementUnlocksRequest(achievementId, offset, count), authenticationData);
        }
        #endregion GetAchievementUnlocks

    }
}
