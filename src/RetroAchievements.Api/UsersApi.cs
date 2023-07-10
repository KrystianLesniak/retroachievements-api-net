using RetroAchievements.Api.Requests.Users;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api
{
    public static class UsersApi
    {
        #region GetAchievementsEarnedBetween
        public static async Task<GetAchievementsEarnedBetweenResponse> GetAchievementsEarnedBetweenAsync(this RetroAchievementsHttpClient client, string user, DateTime from, DateTime to, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetAchievementsEarnedBetweenRequest(user, from, to), authenticationData);
        }

        public static GetAchievementsEarnedBetweenResponse GetAchievementsEarnedBetween(this RetroAchievementsHttpClient client, string user, DateTime from, DateTime to, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetAchievementsEarnedBetweenRequest(user, from, to), authenticationData);
        }
        #endregion GetAchievementsEarnedBetween

        #region GetAchievementsEarnedOnDay
        public static async Task<GetAchievementsEarnedOnDayResponse> GetAchievementsEarnedOnDayAsync(this RetroAchievementsHttpClient client, string user, DateTime date, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetAchievementsEarnedOnDayRequest(user, date), authenticationData);
        }

        public static GetAchievementsEarnedOnDayResponse GetAchievementsEarnedOnDay(this RetroAchievementsHttpClient client, string user, DateTime date, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetAchievementsEarnedOnDayRequest(user, date), authenticationData);
        }
        #endregion GetAchievementsEarnedOnDay

        #region GetGameInfoAndUserProgress
        public static async Task<GetGameInfoAndUserProgressResponse> GetGameInfoAndUserProgressAsync(this RetroAchievementsHttpClient client, int gameId, string username, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetGameInfoAndUserProgressRequest(gameId, username), authenticationData);
        }

        public static GetGameInfoAndUserProgressResponse GetGameInfoAndUserProgress(this RetroAchievementsHttpClient client, int gameId, string username, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGameInfoAndUserProgressRequest(gameId, username), authenticationData);
        }
        #endregion GetGameInfoAndUserProgress

        #region GetUserAwards
        public static async Task<GetUserAwardsResponse> GetUserAwardsAsync(this RetroAchievementsHttpClient client, string username, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetUserAwardsRequest(username), authenticationData);
        }

        public static GetUserAwardsResponse GetUserAwards(this RetroAchievementsHttpClient client, string username, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserAwardsRequest(username), authenticationData);
        }
        #endregion GetUserAwards

        #region GetUserClaims
        public static async Task<GetUserClaimsResponse> GetUserClaimsAsync(this RetroAchievementsHttpClient client, string username, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetUserClaimsRequest(username), authenticationData);
        }

        public static GetUserClaimsResponse GetUserClaims(this RetroAchievementsHttpClient client, string username, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserClaimsRequest(username), authenticationData);
        }
        #endregion GetUserClaims

        #region GetUserCompletedGames
        public static async Task<GetUserCompletedGamesResponse> GetUserCompletedGamesAsync(this RetroAchievementsHttpClient client, string username, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetUserCompletedGamesRequest(username), authenticationData);
        }

        public static GetUserCompletedGamesResponse GetUserCompletedGames(this RetroAchievementsHttpClient client, string username, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserCompletedGamesRequest(username), authenticationData);
        }
        #endregion GetUserCompletedGames

        //#region GetUserGameRankAndScore
        //public static async Task<GetUserGameRankAndScoreResponse> GetUserGameRankAndScoreAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.SendAsync(new GetUserGameRankAndScoreRequest(), authenticationData);
        //}

        //public static GetUserGameRankAndScoreResponse GetUserGameRankAndScore(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.Send(new GetUserGameRankAndScoreRequest(), authenticationData);
        //}
        //#endregion GetUserGameRankAndScore

        //#region GetUserPoints
        //public static async Task<GetUserPointsResponse> GetUserPointsAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.SendAsync(new GetUserPointsRequest(), authenticationData);
        //}

        //public static GetUserPointsResponse GetUserPoints(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.Send(new GetUserPointsRequest(), authenticationData);
        //}
        //#endregion GetUserPoints

        //#region GetUserProgress
        //public static async Task<GetUserProgressResponse> GetUserProgressAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.SendAsync(new GetUserProgressRequest(), authenticationData);
        //}

        //public static GetUserProgressResponse GetUserProgress(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.Send(new GetUserProgressRequest(), authenticationData);
        //}
        //#endregion GetUserProgress

        //#region GetUserRecentAchievements
        //public static async Task<GetUserRecentAchievementsResponse> GetUserRecentAchievementsAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.SendAsync(new GetUserRecentAchievementsRequest(), authenticationData);
        //}

        //public static GetUserRecentAchievementsResponse GetUserRecentAchievements(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.Send(new GetUserRecentAchievementsRequest(), authenticationData);
        //}
        //#endregion GetUserRecentAchievements

        //#region GetUserRecentlyPlayedGames
        //public static async Task<GetUserRecentlyPlayedGamesResponse> GetUserRecentlyPlayedGamesAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.SendAsync(new GetUserRecentlyPlayedGamesRequest(), authenticationData);
        //}
        //public static GetUserRecentlyPlayedGamesResponse GetUserRecentlyPlayedGames(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.Send(new GetUserRecentlyPlayedGamesRequest(), authenticationData);
        //}
        //#endregion GetUserRecentlyPlayedGames

        //#region GetUserSummary
        //public static async Task<GetUserSummaryResponse> GetUserSummaryAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.SendAsync(new GetUserSummaryRequest(), authenticationData);
        //}

        //public static GetUserSummaryResponse GetUserSummary(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.Send(new GetUserSummaryRequest(), authenticationData);
        //}
        //#endregion GetUserSummary
    }
}
