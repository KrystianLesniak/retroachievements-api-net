﻿using RetroAchievements.Api.Requests.Games;
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
        /// <inheritdoc cref="GetGameExtendedDataRequest(int)"/>
        public static async Task<GetGameExtendedDataResponse> GetGameExtendedDataAsync(this IRetroAchievementsHttpClient client, int gameId, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetGameExtendedDataRequest(gameId), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetGameExtendedDataRequest(int)"/>
        public static GetGameExtendedDataResponse GetGameExtendedData(this IRetroAchievementsHttpClient client, int gameId, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGameExtendedDataRequest(gameId), authenticationData);
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
        public static async Task<GetGameRatingResponse> GetGameRatingAsync(this IRetroAchievementsHttpClient client, int gameId, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetGameRatingRequest(gameId), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetGameRatingRequest(int)"/>
        public static GetGameRatingResponse GetGameRating(this IRetroAchievementsHttpClient client, int gameId, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGameRatingRequest(gameId), authenticationData);
        }
        #endregion GetGameRating
    }
}
