using RetroAchievements.Api.Requests.Games;
using RetroAchievements.Api.Response.Games;

namespace RetroAchievements.Api
{
    /// <summary>
    /// Class with extension methods for calling APIs from group "Games"
    /// </summary>
    public static class GamesApi
    {
        #region GetAchievementCount
        /// <inheritdoc cref="GetAchievementIdentifiersRequest(int)"/>
        public static async Task<GetAchievementIdentifiersResponse> GetAchievementIdentifiersAsync(this IRetroAchievementsHttpClient client, int gameId, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetAchievementIdentifiersRequest(gameId), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetAchievementIdentifiersRequest(int)"/>
        public static GetAchievementIdentifiersResponse GetAchievementIdentifiers(this IRetroAchievementsHttpClient client, int gameId, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetAchievementIdentifiersRequest(gameId), authenticationData);
        }
        #endregion GetAchievementCount

        #region GetAchievementDistribution
        /// <inheritdoc cref="GetAchievementDistributionRequest(int, bool, bool)"/>
        public static async Task<GetAchievementDistributionResponse> GetAchievementDistributionAsync(this IRetroAchievementsHttpClient client, int gameId, bool hardcoreOnly = false, bool unofficialAchievements = false, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetAchievementDistributionRequest(gameId, hardcoreOnly, unofficialAchievements), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetAchievementDistributionRequest(int, bool, bool)"/>
        public static GetAchievementDistributionResponse GetAchievementDistribution(this IRetroAchievementsHttpClient client, int gameId, bool hardcoreOnly = false, bool unofficialAchievements = false, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetAchievementDistributionRequest(gameId, hardcoreOnly, unofficialAchievements), authenticationData);
        }
        #endregion GetAchievementDistribution

        #region GetGame
        /// <inheritdoc cref="GetGameDataRequest(int)"/>
        public static async Task<GetGameDataResponse> GetGameDataAsync(this IRetroAchievementsHttpClient client, int gameId, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetGameDataRequest(gameId), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetGameDataRequest(int)"/>
        public static GetGameDataResponse GetGameData(this IRetroAchievementsHttpClient client, int gameId, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGameDataRequest(gameId), authenticationData);
        }
        #endregion GetGame

        #region GetGameExtended
        /// <inheritdoc cref="GetGameExtendedDataRequest(int, bool)"/>
        public static async Task<GetGameExtendedDataResponse> GetGameExtendedDataAsync(this IRetroAchievementsHttpClient client, int gameId, bool unofficialAchievements = false, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetGameExtendedDataRequest(gameId, unofficialAchievements), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetGameExtendedDataRequest(int, bool)"/>
        public static GetGameExtendedDataResponse GetGameExtendedData(this IRetroAchievementsHttpClient client, int gameId, bool unofficialAchievements = false, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGameExtendedDataRequest(gameId, unofficialAchievements), authenticationData);
        }
        #endregion GetGameExtended

        #region GetGameRankAndScore
        /// <inheritdoc cref="GetGameRankAndScoreRequest(int, RankType)"/>
        public static async Task<GetGameRankAndScoreResponse> GetGameRankAndScoreAsync(this IRetroAchievementsHttpClient client, int gameId, RankType rankType = RankType.HighScores, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetGameRankAndScoreRequest(gameId, rankType), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetGameRankAndScoreRequest(int, RankType)"/>
        public static GetGameRankAndScoreResponse GetGameRankAndScore(this IRetroAchievementsHttpClient client, int gameId, RankType rankType = RankType.HighScores, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGameRankAndScoreRequest(gameId, rankType), authenticationData);
        }
        #endregion GetGameRankAndScore

        #region GetGameRating

        /// <inheritdoc cref="GetGameRatingRequest(int)"/>
        [Obsolete("API_GetGameRating has been removed from RetroAchievements API (returns HTTP 410 Gone).")]
        public static async Task<GetGameRatingResponse> GetGameRatingAsync(this IRetroAchievementsHttpClient client, int gameId, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetGameRatingRequest(gameId), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetGameRatingRequest(int)"/>
        [Obsolete("API_GetGameRating has been removed from RetroAchievements API (returns HTTP 410 Gone).")]
        public static GetGameRatingResponse GetGameRating(this IRetroAchievementsHttpClient client, int gameId, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGameRatingRequest(gameId), authenticationData);
        }
        #endregion GetGameRating

        #region GetGameHashes
        /// <inheritdoc cref="GetGameHashesRequest(int)"/>
        public static async Task<GetGameHashesResponse> GetGameHashesAsync(this IRetroAchievementsHttpClient client, int gameId, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetGameHashesRequest(gameId), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetGameHashesRequest(int)"/>
        public static GetGameHashesResponse GetGameHashes(this IRetroAchievementsHttpClient client, int gameId, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGameHashesRequest(gameId), authenticationData);
        }
        #endregion GetGameHashes

        #region GetGameProgression
        /// <inheritdoc cref="GetGameProgressionRequest(int, bool)"/>
        public static async Task<GetGameProgressionResponse> GetGameProgressionAsync(this IRetroAchievementsHttpClient client, int gameId, bool hardcore = false, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetGameProgressionRequest(gameId, hardcore), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetGameProgressionRequest(int, bool)"/>
        public static GetGameProgressionResponse GetGameProgression(this IRetroAchievementsHttpClient client, int gameId, bool hardcore = false, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGameProgressionRequest(gameId, hardcore), authenticationData);
        }
        #endregion GetGameProgression
    }
}
