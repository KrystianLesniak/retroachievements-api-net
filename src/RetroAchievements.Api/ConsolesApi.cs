
using RetroAchievements.Api.Requests.Consoles;
using RetroAchievements.Api.Response.Consoles;

namespace RetroAchievements.Api
{
    /// <summary>
    /// Class with extension methods for calling APIs from group "Consoles"
    /// </summary>
    public static class ConsolesApi
    {
        #region GetConsoleIds
        /// <inheritdoc cref="GetConsoleIdsRequest()"/>
        public static async Task<GetConsoleIdsResponse> GetConsoleIdsAsync(this IRetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetConsoleIdsRequest(), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetConsoleIdsRequest()"/>
        public static GetConsoleIdsResponse GetConsoleIds(this IRetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetConsoleIdsRequest(), authenticationData);
        }
        #endregion GetConsoleIds

        #region GetGamesList
        /// <inheritdoc cref="GetGamesListRequest(int, bool, bool)"/>
        public static async Task<GetGamesListResponse> GetGamesListAsync(this IRetroAchievementsHttpClient client, int consoleId, bool onlyWithAchievements = false, bool getHashes = false, RetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetGamesListRequest(consoleId, onlyWithAchievements, getHashes), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetGamesListRequest(int, bool, bool)"/>
        public static GetGamesListResponse GetGamesList(this IRetroAchievementsHttpClient client, int consoleId, bool onlyWithAchievements = false, bool getHashes = false, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGamesListRequest(consoleId, onlyWithAchievements, getHashes), authenticationData);
        }
        #endregion GetGamesList
    }
}
