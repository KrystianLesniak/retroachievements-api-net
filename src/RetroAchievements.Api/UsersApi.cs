using RetroAchievements.Api.Requests.Enums;
using RetroAchievements.Api.Requests.Users;
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
        public static async Task<GetAchievementsEarnedBetweenResponse> GetAchievementsEarnedBetweenAsync(this IRetroAchievementsHttpClient client, string username, DateTime from, DateTime to, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetAchievementsEarnedBetweenRequest(username, from, to), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetAchievementsEarnedBetweenRequest(string, DateTime, DateTime)"/>
        public static GetAchievementsEarnedBetweenResponse GetAchievementsEarnedBetween(this IRetroAchievementsHttpClient client, string username, DateTime from, DateTime to, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetAchievementsEarnedBetweenRequest(username, from, to), authenticationData);
        }
        #endregion GetAchievementsEarnedBetween

        #region GetAchievementsEarnedOnDay
        /// <inheritdoc cref="GetAchievementsEarnedOnDayRequest(string, DateTime)"/>
        public static async Task<GetAchievementsEarnedOnDayResponse> GetAchievementsEarnedOnDayAsync(this IRetroAchievementsHttpClient client, string username, DateTime date, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetAchievementsEarnedOnDayRequest(username, date), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetAchievementsEarnedOnDayRequest(string, DateTime)"/>
        public static GetAchievementsEarnedOnDayResponse GetAchievementsEarnedOnDay(this IRetroAchievementsHttpClient client, string username, DateTime date, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetAchievementsEarnedOnDayRequest(username, date), authenticationData);
        }
        #endregion GetAchievementsEarnedOnDay

        #region GetUserAwards
        /// <inheritdoc cref="GetUserAwardsRequest(string)"/>
        public static async Task<GetUserAwardsResponse> GetUserAwardsAsync(this IRetroAchievementsHttpClient client, string username, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserAwardsRequest(username), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserAwardsRequest(string)"/>
        public static GetUserAwardsResponse GetUserAwards(this IRetroAchievementsHttpClient client, string username, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserAwardsRequest(username), authenticationData);
        }
        #endregion GetUserAwards

        #region GetUserClaims
        /// <inheritdoc cref="GetUserClaimsRequest(string)"/>
        public static async Task<GetUserClaimsResponse> GetUserClaimsAsync(this IRetroAchievementsHttpClient client, string username, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserClaimsRequest(username), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserClaimsRequest(string)"/>
        public static GetUserClaimsResponse GetUserClaims(this IRetroAchievementsHttpClient client, string username, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserClaimsRequest(username), authenticationData);
        }
        #endregion GetUserClaims

        #region GetUserAllGamesProgress
        /// <inheritdoc cref="GetUserAllGamesProgressRequest(string)"/>
        public static async Task<GetUserAllGamesProgressResponse> GetUserAllGamesProgressAsync(this IRetroAchievementsHttpClient client, string username, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserAllGamesProgressRequest(username), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserAllGamesProgressRequest(string)"/>
        public static GetUserAllGamesProgressResponse GetUserAllGamesProgress(this IRetroAchievementsHttpClient client, string username, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserAllGamesProgressRequest(username), authenticationData);
        }
        #endregion GetUserAllGamesProgress

        #region GetGameDataAndUserProgress
        /// <inheritdoc cref="GetGameDataAndUserProgressRequest(int, string, bool)"/>
        public static async Task<GetGameDataAndUserProgressResponse> GetGameDataAndUserProgressAsync(this IRetroAchievementsHttpClient client, int gameId, string username, bool includeHighestAward = false, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetGameDataAndUserProgressRequest(gameId, username, includeHighestAward), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetGameDataAndUserProgressRequest(int, string, bool)"/>
        public static GetGameDataAndUserProgressResponse GetGameDataAndUserProgress(this IRetroAchievementsHttpClient client, int gameId, string username, bool includeHighestAward = false, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGameDataAndUserProgressRequest(gameId, username, includeHighestAward), authenticationData);
        }
        #endregion GetGameDataAndUserProgress

        #region GetUserGameRankAndScore
        /// <inheritdoc cref="GetUserGameRankAndScoreRequest(string, int)"/>
        public static async Task<GetUserGameRankAndScoreResponse> GetUserGameRankAndScoreAsync(this IRetroAchievementsHttpClient client, string username, int gameId, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserGameRankAndScoreRequest(username, gameId), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserGameRankAndScoreRequest(string, int)"/>
        public static GetUserGameRankAndScoreResponse GetUserGameRankAndScore(this IRetroAchievementsHttpClient client, string username, int gameId, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserGameRankAndScoreRequest(username, gameId), authenticationData);
        }
        #endregion GetUserGameRankAndScore

        #region GetUserPoints
        /// <inheritdoc cref="GetUserPointsRequest(string)"/>
        public static async Task<GetUserPointsResponse> GetUserPointsAsync(this IRetroAchievementsHttpClient client, string username, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserPointsRequest(username), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserPointsRequest(string)"/>
        public static GetUserPointsResponse GetUserPoints(this IRetroAchievementsHttpClient client, string username, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserPointsRequest(username), authenticationData);
        }
        #endregion GetUserPoints

        #region GetUserRankAndPoints
        /// <inheritdoc cref="GetUserRankAndPointsRequest(string)"/>
        public static async Task<GetUserRankAndPointsResponse> GetUserRankAndPointsAsync(this IRetroAchievementsHttpClient client, string username, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserRankAndPointsRequest(username), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserRankAndPointsRequest(string)"/>
        public static GetUserRankAndPointsResponse GetUserRankAndPoints(this IRetroAchievementsHttpClient client, string username, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserRankAndPointsRequest(username), authenticationData);
        }
        #endregion GetUserRankAndPoints

        #region GetUserGamesProgress
        /// <inheritdoc cref="GetUserGamesProgressRequest(string ,IEnumerable{int})"/>
        public static async Task<GetUserGamesProgressResponse> GetUserGamesProgressAsync(this IRetroAchievementsHttpClient client, string username, IEnumerable<int> gameIds, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserGamesProgressRequest(username, gameIds), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserGamesProgressRequest(string ,IEnumerable{int})"/>
        public static GetUserGamesProgressResponse GetUserGamesProgress(this IRetroAchievementsHttpClient client, string username, IEnumerable<int> gameIds, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserGamesProgressRequest(username, gameIds), authenticationData);
        }
        #endregion GetUserGamesProgress

        #region GetUserRecentAchievements
        /// <inheritdoc cref="GetUserRecentAchievementsRequest(string, int)"/>
        public static async Task<GetUserRecentAchievementsResponse> GetUserRecentAchievementsAsync(this IRetroAchievementsHttpClient client, string username, int minutesToLookBack = 60, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserRecentAchievementsRequest(username, minutesToLookBack), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserRecentAchievementsRequest(string, int)"/>
        public static GetUserRecentAchievementsResponse GetUserRecentAchievements(this IRetroAchievementsHttpClient client, string username, int minutesToLookBack = 60, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserRecentAchievementsRequest(username, minutesToLookBack), authenticationData);
        }
        #endregion GetUserRecentAchievements

        #region GetUserRecentlyPlayedGames
        /// <inheritdoc cref="GetUserRecentlyPlayedGamesRequest(string, int, int)"/>
        public static async Task<GetUserRecentlyPlayedGamesResponse> GetUserRecentlyPlayedGamesAsync(this IRetroAchievementsHttpClient client, string username, int offset = 0, int count = 10, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserRecentlyPlayedGamesRequest(username, offset, count), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserRecentlyPlayedGamesRequest(string, int, int)"/>
        public static GetUserRecentlyPlayedGamesResponse GetUserRecentlyPlayedGames(this IRetroAchievementsHttpClient client, string username, int offset = 0, int count = 10, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserRecentlyPlayedGamesRequest(username, offset, count), authenticationData);
        }
        #endregion GetUserRecentlyPlayedGames

        #region GetUserSummary
        /// <inheritdoc cref="GetUserSummaryRequest(string, int, int)"/>
        public static async Task<GetUserSummaryResponse> GetUserSummaryAsync(this IRetroAchievementsHttpClient client, string username, int recentGamesToReturn = 0, int recentAchievementsToReturn = 10, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserSummaryRequest(username, recentGamesToReturn, recentAchievementsToReturn), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserSummaryRequest(string, int, int)"/>
        public static GetUserSummaryResponse GetUserSummary(this IRetroAchievementsHttpClient client, string username, int recentGamesToReturn = 0, int recentAchievementsToReturn = 10, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserSummaryRequest(username, recentGamesToReturn, recentAchievementsToReturn), authenticationData);
        }
        #endregion GetUserSummary

        #region GetUserProfile
        /// <inheritdoc cref="GetUserProfileRequest(string)"/>
        public static async Task<GetUserProfileResponse> GetUserProfileAsync(this IRetroAchievementsHttpClient client, string username, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserProfileRequest(username), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserProfileRequest(string)"/>
        public static GetUserProfileResponse GetUserProfile(this IRetroAchievementsHttpClient client, string username, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserProfileRequest(username), authenticationData);
        }
        #endregion GetUserProfile

        #region GetUserCompletionProgress
        /// <inheritdoc cref="GetUserCompletionProgressRequest(string, int, int)"/>
        public static async Task<GetUserCompletionProgressResponse> GetUserCompletionProgressAsync(this IRetroAchievementsHttpClient client, string username, int offset = 0, int count = 100, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserCompletionProgressRequest(username, offset, count), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserCompletionProgressRequest(string, int, int)"/>
        public static GetUserCompletionProgressResponse GetUserCompletionProgress(this IRetroAchievementsHttpClient client, string username, int offset = 0, int count = 100, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserCompletionProgressRequest(username, offset, count), authenticationData);
        }
        #endregion GetUserCompletionProgress

        #region GetUserSetRequests
        /// <inheritdoc cref="GetUserSetRequestsRequest(string, RequestListType)"/>
        public static async Task<GetUserSetRequestsResponse> GetUserSetRequestsAsync(this IRetroAchievementsHttpClient client, string username, RequestListType requestListType = RequestListType.ActiveRequests, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserSetRequestsRequest(username, requestListType), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserSetRequestsRequest(string, RequestListType)"/>
        public static GetUserSetRequestsResponse GetUserSetRequests(this IRetroAchievementsHttpClient client, string username, RequestListType requestListType = RequestListType.ActiveRequests, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserSetRequestsRequest(username, requestListType), authenticationData);
        }
        #endregion GetUserSetRequests

        #region GetUserWantToPlayList
        /// <inheritdoc cref="GetUserWantToPlayListRequest(string, int, int)"/>
        public static async Task<GetUserWantToPlayListResponse> GetUserWantToPlayListAsync(this IRetroAchievementsHttpClient client, string username, int offset = 0, int count = 100, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserWantToPlayListRequest(username, offset, count), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserWantToPlayListRequest(string, int, int)"/>
        public static GetUserWantToPlayListResponse GetUserWantToPlayList(this IRetroAchievementsHttpClient client, string username, int offset = 0, int count = 100, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserWantToPlayListRequest(username, offset, count), authenticationData);
        }
        #endregion GetUserWantToPlayList

        #region GetUsersIFollow
        /// <inheritdoc cref="GetUsersIFollowRequest(int, int)"/>
        public static async Task<GetUsersIFollowResponse> GetUsersIFollowAsync(this IRetroAchievementsHttpClient client, int offset = 0, int count = 100, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUsersIFollowRequest(offset, count), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUsersIFollowRequest(int, int)"/>
        public static GetUsersIFollowResponse GetUsersIFollow(this IRetroAchievementsHttpClient client, int offset = 0, int count = 100, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUsersIFollowRequest(offset, count), authenticationData);
        }
        #endregion GetUsersIFollow

        #region GetUsersFollowingMe
        /// <inheritdoc cref="GetUsersFollowingMeRequest(int, int)"/>
        public static async Task<GetUsersFollowingMeResponse> GetUsersFollowingMeAsync(this IRetroAchievementsHttpClient client, int offset = 0, int count = 100, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUsersFollowingMeRequest(offset, count), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUsersFollowingMeRequest(int, int)"/>
        public static GetUsersFollowingMeResponse GetUsersFollowingMe(this IRetroAchievementsHttpClient client, int offset = 0, int count = 100, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUsersFollowingMeRequest(offset, count), authenticationData);
        }
        #endregion GetUsersFollowingMe
    }
}
