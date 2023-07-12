
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

        #region GetGameList
        /// <inheritdoc cref="GetConsoleIdsRequest()"/>
        public static async Task<GetGameListResponse> GetGameListAsync(this RetroAchievementsHttpClient client, int consoleId, bool onlyWithAchievements = false, bool getHashes = false, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetGameListRequest(consoleId, onlyWithAchievements, getHashes), authenticationData);
        }

        /// <inheritdoc cref="GetConsoleIdsRequest()"/>
        public static GetGameListResponse GetGameList(this RetroAchievementsHttpClient client, int consoleId, bool onlyWithAchievements = false, bool getHashes = false, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGameListRequest(consoleId, onlyWithAchievements, getHashes), authenticationData);
        }
        #endregion GetGameList
    }
}
