﻿using RetroAchievements.Api.Requests.Users;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api
{
    /// <summary>
    /// Class with extension methods for calling APIs from group "Users"
    /// </summary>
    public static class UsersApi
    {
        #region GetAchievementsEarnedBetween
        /// <inheritdoc cref="GetAchievementsEarnedBetweenRequest(string, DateTime, DateTime)"/>
        public static async Task<GetAchievementsEarnedBetweenResponse> GetAchievementsEarnedBetweenAsync(this RetroAchievementsHttpClient client, string username, DateTime from, DateTime to, RetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetAchievementsEarnedBetweenRequest(username, from, to), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetAchievementsEarnedBetweenRequest(string, DateTime, DateTime)"/>
        public static GetAchievementsEarnedBetweenResponse GetAchievementsEarnedBetween(this RetroAchievementsHttpClient client, string username, DateTime from, DateTime to, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetAchievementsEarnedBetweenRequest(username, from, to), authenticationData);
        }
        #endregion GetAchievementsEarnedBetween

        #region GetAchievementsEarnedOnDay
        /// <inheritdoc cref="GetAchievementsEarnedOnDayRequest(string, DateTime)"/>
        public static async Task<GetAchievementsEarnedOnDayResponse> GetAchievementsEarnedOnDayAsync(this RetroAchievementsHttpClient client, string username, DateTime date, RetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetAchievementsEarnedOnDayRequest(username, date), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetAchievementsEarnedOnDayRequest(string, DateTime)"/>
        public static GetAchievementsEarnedOnDayResponse GetAchievementsEarnedOnDay(this RetroAchievementsHttpClient client, string username, DateTime date, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetAchievementsEarnedOnDayRequest(username, date), authenticationData);
        }
        #endregion GetAchievementsEarnedOnDay

        #region GetUserAwards
        /// <inheritdoc cref="GetUserAwardsRequest(string)"/>
        public static async Task<GetUserAwardsResponse> GetUserAwardsAsync(this RetroAchievementsHttpClient client, string username, RetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserAwardsRequest(username), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserAwardsRequest(string)"/>
        public static GetUserAwardsResponse GetUserAwards(this RetroAchievementsHttpClient client, string username, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserAwardsRequest(username), authenticationData);
        }
        #endregion GetUserAwards

        #region GetUserClaims
        /// <inheritdoc cref="GetUserClaimsRequest(string)"/>
        public static async Task<GetUserClaimsResponse> GetUserClaimsAsync(this RetroAchievementsHttpClient client, string username, RetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserClaimsRequest(username), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserClaimsRequest(string)"/>
        public static GetUserClaimsResponse GetUserClaims(this RetroAchievementsHttpClient client, string username, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserClaimsRequest(username), authenticationData);
        }
        #endregion GetUserClaims

        #region GetUserAllGamesProgress
        /// <inheritdoc cref="GetUserAllGamesProgressRequest(string)"/>
        public static async Task<GetUserAllGamesProgressResponse> GetUserAllGamesProgressAsync(this RetroAchievementsHttpClient client, string username, RetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserAllGamesProgressRequest(username), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserAllGamesProgressRequest(string)"/>
        public static GetUserAllGamesProgressResponse GetUserAllGamesProgress(this RetroAchievementsHttpClient client, string username, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserAllGamesProgressRequest(username), authenticationData);
        }
        #endregion GetUserAllGamesProgress

        #region GetUserGameRankAndScore
        /// <inheritdoc cref="GetUserGameRankAndScoreRequest(string, int)"/>
        public static async Task<GetUserGameRankAndScoreResponse> GetUserGameRankAndScoreAsync(this RetroAchievementsHttpClient client, string username, int gameId, RetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserGameRankAndScoreRequest(username, gameId), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserGameRankAndScoreRequest(string, int)"/>
        public static GetUserGameRankAndScoreResponse GetUserGameRankAndScore(this RetroAchievementsHttpClient client, string username, int gameId, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserGameRankAndScoreRequest(username, gameId), authenticationData);
        }
        #endregion GetUserGameRankAndScore

        #region GetUserPoints
        /// <inheritdoc cref="GetUserPointsRequest(string)"/>
        public static async Task<GetUserPointsResponse> GetUserPointsAsync(this RetroAchievementsHttpClient client, string username, RetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserPointsRequest(username), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserPointsRequest(string)"/>
        public static GetUserPointsResponse GetUserPoints(this RetroAchievementsHttpClient client, string username, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserPointsRequest(username), authenticationData);
        }
        #endregion GetUserPoints

        #region GetUserRankAndPoints
        /// <inheritdoc cref="GetUserRankAndPointsRequest(string)"/>
        public static async Task<GetUserRankAndPointsResponse> GetUserRankAndPointsAsync(this RetroAchievementsHttpClient client, string username, RetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserRankAndPointsRequest(username), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserRankAndPointsRequest(string)"/>
        public static GetUserRankAndPointsResponse GetRankAndPointsPoints(this RetroAchievementsHttpClient client, string username, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserRankAndPointsRequest(username), authenticationData);
        }
        #endregion GetUserRankAndPoints

        #region GetUserGamesProgress
        /// <inheritdoc cref="GetUserGamesProgressRequest(string ,IEnumerable{int})"/>
        public static async Task<GetUserGamesProgressResponse> GetUserGamesProgressAsync(this RetroAchievementsHttpClient client, string username, IEnumerable<int> gameIds, RetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserGamesProgressRequest(username, gameIds), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserGamesProgressRequest(string ,IEnumerable{int})"/>
        public static GetUserGamesProgressResponse GetUserGamesProgress(this RetroAchievementsHttpClient client, string username, IEnumerable<int> gameIds, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserGamesProgressRequest(username, gameIds), authenticationData);
        }
        #endregion GetUserGamesProgress

        #region GetUserRecentAchievements
        /// <inheritdoc cref="GetUserRecentAchievementsRequest(string, int)"/>
        public static async Task<GetUserRecentAchievementsResponse> GetUserRecentAchievementsAsync(this RetroAchievementsHttpClient client, string username, int minutesToLookBack = 60, RetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserRecentAchievementsRequest(username, minutesToLookBack), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserRecentAchievementsRequest(string, int)"/>
        public static GetUserRecentAchievementsResponse GetUserRecentAchievements(this RetroAchievementsHttpClient client, string username, int minutesToLookBack = 60, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserRecentAchievementsRequest(username, minutesToLookBack), authenticationData);
        }
        #endregion GetUserRecentAchievements

    }
}
