
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
        public static async Task<GetConsoleIdsResponse> GetConsoleIdsAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetConsoleIdsRequest(), authenticationData);
        }

        /// <inheritdoc cref="GetConsoleIdsRequest()"/>
        public static GetConsoleIdsResponse GetConsoleIds(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetConsoleIdsRequest(), authenticationData);
        }
        #endregion GetConsoleIds

        #region GetGamesList
        /// <inheritdoc cref="GetGamesListRequest(int, bool, bool)"/>
        public static async Task<GetGamesListResponse> GetGamesListAsync(this RetroAchievementsHttpClient client, int consoleId, bool onlyWithAchievements = false, bool getHashes = false, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetGamesListRequest(consoleId, onlyWithAchievements, getHashes), authenticationData);
        }

        /// <inheritdoc cref="GetGamesListRequest(int, bool, bool)"/>
        public static GetGamesListResponse GetGamesList(this RetroAchievementsHttpClient client, int consoleId, bool onlyWithAchievements = false, bool getHashes = false, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGamesListRequest(consoleId, onlyWithAchievements, getHashes), authenticationData);
        }
        #endregion GetGamesList
    }
}
