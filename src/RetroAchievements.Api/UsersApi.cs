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

        //#region GetGameInfoAndUserProgress
        //public static async Task<GetGameInfoAndUserProgressResponse> GetGameInfoAndUserProgressAsync(this RetroAchievementsHttpClient client, int gameId, string username, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetGameInfoAndUserProgressAsync(new GetGameInfoAndUserProgressRequest(gameId, username), authenticationData);
        //}

        //public static GetGameInfoAndUserProgressResponse GetGameInfoAndUserProgress(this RetroAchievementsHttpClient client, int gameId, string username, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetGameInfoAndUserProgress(new GetGameInfoAndUserProgressRequest(gameId, username), authenticationData);
        //}
        //#endregion GetGameInfoAndUserProgress

        //#region GetUserAwards
        //public static async Task<GetUserAwardsResponse> GetUserAwardsAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetUserAwardsAsync(new GetUserAwardsRequest(), authenticationData);
        //}

        //public static GetUserAwardsResponse GetUserAwards(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetUserAwards(new GetUserAwardsRequest(), authenticationData);
        //}
        //#endregion GetUserAwards

        //#region GetUserClaims
        //public static async Task<GetUserClaimsResponse> GetUserClaimsAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetUserClaimsAsync(new GetUserClaimsRequest(), authenticationData);
        //}

        //public static GetUserClaimsResponse GetUserClaims(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetUserClaims(new GetUserClaimsRequest(), authenticationData);
        //}
        //#endregion GetUserClaims

        //#region GetUserCompletedGames
        //public static async Task<GetUserCompletedGamesResponse> GetUserCompletedGamesAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetUserCompletedGamesAsync(new GetUserCompletedGamesRequest(), authenticationData);
        //}

        //public static GetUserCompletedGamesResponse GetUserCompletedGames(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetUserCompletedGames(new GetUserCompletedGamesRequest(), authenticationData);
        //}
        //#endregion GetUserCompletedGames

        //#region GetUserGameRankAndScore
        //public static async Task<GetUserGameRankAndScoreResponse> GetUserGameRankAndScoreAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetUserGameRankAndScoreAsync(new GetUserGameRankAndScoreRequest(), authenticationData);
        //}

        //public static GetUserGameRankAndScoreResponse GetUserGameRankAndScore(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetUserGameRankAndScore(new GetUserGameRankAndScoreRequest(), authenticationData);
        //}
        //#endregion GetUserGameRankAndScore

        //#region GetUserPoints
        //public static async Task<GetUserPointsResponse> GetUserPointsAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetUserPointsAsync(new GetUserPointsRequest(), authenticationData);
        //}

        //public static GetUserPointsResponse GetUserPoints(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetUserPoints(new GetUserPointsRequest(), authenticationData);
        //}
        //#endregion GetUserPoints

        //#region GetUserProgress
        //public static async Task<GetUserProgressResponse> GetUserProgressAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetUserProgressAsync(new GetUserProgressRequest(), authenticationData);
        //}

        //public static GetUserProgressResponse GetUserProgress(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetUserProgress(new GetUserProgressRequest(), authenticationData);
        //}
        //#endregion GetUserProgress

        //#region GetUserRecentAchievements
        //public static async Task<GetUserRecentAchievementsResponse> GetUserRecentAchievementsAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetUserRecentAchievementsAsync(new GetUserRecentAchievementsRequest(), authenticationData);
        //}

        //public static GetUserRecentAchievementsResponse GetUserRecentAchievements(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetUserRecentAchievements(new GetUserRecentAchievementsRequest(), authenticationData);
        //}
        //#endregion GetUserRecentAchievements

        //#region GetUserRecentlyPlayedGames
        //public static async Task<GetUserRecentlyPlayedGamesResponse> GetUserRecentlyPlayedGamesAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetUserRecentlyPlayedGamesAsync(new GetUserRecentlyPlayedGamesRequest(), authenticationData);
        //}
        //public static GetUserRecentlyPlayedGamesResponse GetUserRecentlyPlayedGames(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetUserRecentlyPlayedGames(new GetUserRecentlyPlayedGamesRequest(), authenticationData);
        //}
        //#endregion GetUserRecentlyPlayedGames

        //#region GetUserSummary
        //public static async Task<GetUserSummaryResponse> GetUserSummaryAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetUserSummaryAsync(new GetUserSummaryRequest(), authenticationData);
        //}

        //public static GetUserSummaryResponse GetUserSummary(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetUserSummary(new GetUserSummaryRequest(), authenticationData);
        //}
        //#endregion GetUserSummary
    }
}
