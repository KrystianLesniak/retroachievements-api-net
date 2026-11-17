using RetroAchievements.Api.Requests.Leaderboards;
using RetroAchievements.Api.Response.Leaderboards;

namespace RetroAchievements.Api
{
    /// <summary>
    /// Class with extension methods for calling APIs from group "Leaderboards"
    /// </summary>
    public static class LeaderboardsApi
    {
        #region GetGameLeaderboards
        /// <inheritdoc cref="GetGameLeaderboardsRequest(int, int, int)"/>
        public static async Task<GetGameLeaderboardsResponse> GetGameLeaderboardsAsync(this IRetroAchievementsHttpClient client, int gameId, int offset = 0, int count = 100, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetGameLeaderboardsRequest(gameId, offset, count), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetGameLeaderboardsRequest(int, int, int)"/>
        public static GetGameLeaderboardsResponse GetGameLeaderboards(this IRetroAchievementsHttpClient client, int gameId, int offset = 0, int count = 100, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGameLeaderboardsRequest(gameId, offset, count), authenticationData);
        }
        #endregion GetGameLeaderboards

        #region GetLeaderboardEntries
        /// <inheritdoc cref="GetLeaderboardEntriesRequest(int, int, int)"/>
        public static async Task<GetLeaderboardEntriesResponse> GetLeaderboardEntriesAsync(this IRetroAchievementsHttpClient client, int leaderboardId, int offset = 0, int count = 100, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetLeaderboardEntriesRequest(leaderboardId, offset, count), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetLeaderboardEntriesRequest(int, int, int)"/>
        public static GetLeaderboardEntriesResponse GetLeaderboardEntries(this IRetroAchievementsHttpClient client, int leaderboardId, int offset = 0, int count = 100, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetLeaderboardEntriesRequest(leaderboardId, offset, count), authenticationData);
        }
        #endregion GetLeaderboardEntries

        #region GetUserGameLeaderboards
        /// <inheritdoc cref="GetUserGameLeaderboardsRequest(int, string, int, int)"/>
        public static async Task<GetUserGameLeaderboardsResponse> GetUserGameLeaderboardsAsync(this IRetroAchievementsHttpClient client, int gameId, string username, int offset = 0, int count = 200, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserGameLeaderboardsRequest(gameId, username, offset, count), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserGameLeaderboardsRequest(int, string, int, int)"/>
        public static GetUserGameLeaderboardsResponse GetUserGameLeaderboards(this IRetroAchievementsHttpClient client, int gameId, string username, int offset = 0, int count = 200, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserGameLeaderboardsRequest(gameId, username, offset, count), authenticationData);
        }
        #endregion GetUserGameLeaderboards
    }
}
