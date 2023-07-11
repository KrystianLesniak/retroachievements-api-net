
using RetroAchievements.Api.Requests.Consoles;
using RetroAchievements.Api.Response.Consoles;

namespace RetroAchievements.Api
{
    public static class ConsolesApi
    {
        #region GetConsoleIds
        public static async Task<GetConsoleIdsResponse> GetConsoleIdsAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetConsoleIdsRequest(), authenticationData);
        }
        public static GetConsoleIdsResponse GetConsoleIds(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetConsoleIdsRequest(), authenticationData);
        }
        #endregion GetConsoleIds

        #region GetGameList
        public static async Task<GetGameListResponse> GetGameListAsync(this RetroAchievementsHttpClient client, int consoleId, bool onlyWithAchievements = false, bool getHashes = false, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetGameListRequest(consoleId, onlyWithAchievements, getHashes), authenticationData);
        }
        public static GetGameListResponse GetGameList(this RetroAchievementsHttpClient client, int consoleId, bool onlyWithAchievements = false, bool getHashes = false, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGameListRequest(consoleId, onlyWithAchievements, getHashes), authenticationData);
        }
        #endregion GetGameList
    }
}
