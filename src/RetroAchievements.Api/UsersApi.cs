using RetroAchievements.Api.Requests.Users;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api
{
    public static class UsersApi
    {
        //#region GetAchievementsEarnedBetween
        //public static async Task<GetAchievementsEarnedBetweenResponse> GetAchievementsEarnedBetweenAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetAchievementsEarnedBetweenAsync(new GetAchievementsEarnedBetweenRequest(), authenticationData);
        //}

        //public static async Task<GetAchievementsEarnedBetweenResponse> GetAchievementsEarnedBetweenAsync(this RetroAchievementsHttpClient client, GetAchievementsEarnedBetweenRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.HandleRequestCallAsync<GetAchievementsEarnedBetweenResponse>(request, authenticationData);
        //}

        //public static GetAchievementsEarnedBetweenResponse GetAchievementsEarnedBetween(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetAchievementsEarnedBetween(new GetAchievementsEarnedBetweenRequest(), authenticationData);
        //}

        //public static GetAchievementsEarnedBetweenResponse GetAchievementsEarnedBetween(this RetroAchievementsHttpClient client, GetAchievementsEarnedBetweenRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.HandleRequestCall<GetAchievementsEarnedBetweenResponse>(request, authenticationData);
        //}
        //#endregion GetAchievementsEarnedBetween

        //#region GetAchievementsEarnedOnDay
        //public static async Task<GetAchievementsEarnedOnDayResponse> GetAchievementsEarnedOnDayAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetAchievementsEarnedOnDayAsync(new GetAchievementsEarnedOnDayRequest(), authenticationData);
        //}

        //public static async Task<GetAchievementsEarnedOnDayResponse> GetAchievementsEarnedOnDayAsync(this RetroAchievementsHttpClient client, GetAchievementsEarnedOnDayRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.HandleRequestCallAsync<GetAchievementsEarnedOnDayResponse>(request, authenticationData);
        //}

        //public static GetAchievementsEarnedOnDayResponse GetAchievementsEarnedOnDay(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetAchievementsEarnedOnDay(new GetAchievementsEarnedOnDayRequest(), authenticationData);
        //}

        //public static GetAchievementsEarnedOnDayResponse GetAchievementsEarnedOnDay(this RetroAchievementsHttpClient client, GetAchievementsEarnedOnDayRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.HandleRequestCall<GetAchievementsEarnedOnDayResponse>(request, authenticationData);
        //}
        //#endregion GetAchievementsEarnedOnDay

        //#region GetGameInfoAndUserProgress
        //public static async Task<GetGameInfoAndUserProgressResponse> GetGameInfoAndUserProgressAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetGameInfoAndUserProgressAsync(new GetGameInfoAndUserProgressRequest(), authenticationData);
        //}

        //public static async Task<GetGameInfoAndUserProgressResponse> GetGameInfoAndUserProgressAsync(this RetroAchievementsHttpClient client, GetGameInfoAndUserProgressRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.HandleRequestCallAsync<GetGameInfoAndUserProgressResponse>(request, authenticationData);
        //}

        //public static GetGameInfoAndUserProgressResponse GetGameInfoAndUserProgress(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetGameInfoAndUserProgress(new GetGameInfoAndUserProgressRequest(), authenticationData);
        //}

        //public static GetGameInfoAndUserProgressResponse GetGameInfoAndUserProgress(this RetroAchievementsHttpClient client, GetGameInfoAndUserProgressRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.HandleRequestCall<GetGameInfoAndUserProgressResponse>(request, authenticationData);
        //}
        //#endregion GetGameInfoAndUserProgress

        //#region GetUserAwards
        //public static async Task<GetUserAwardsResponse> GetUserAwardsAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetUserAwardsAsync(new GetUserAwardsRequest(), authenticationData);
        //}

        //public static async Task<GetUserAwardsResponse> GetUserAwardsAsync(this RetroAchievementsHttpClient client, GetUserAwardsRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.HandleRequestCallAsync<GetUserAwardsResponse>(request, authenticationData);
        //}

        //public static GetUserAwardsResponse GetUserAwards(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetUserAwards(new GetUserAwardsRequest(), authenticationData);
        //}

        //public static GetUserAwardsResponse GetUserAwards(this RetroAchievementsHttpClient client, GetUserAwardsRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.HandleRequestCall<GetUserAwardsResponse>(request, authenticationData);
        //}
        //#endregion GetUserAwards

        //#region GetUserClaims
        //public static async Task<GetUserClaimsResponse> GetUserClaimsAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetUserClaimsAsync(new GetUserClaimsRequest(), authenticationData);
        //}

        //public static async Task<GetUserClaimsResponse> GetUserClaimsAsync(this RetroAchievementsHttpClient client, GetUserClaimsRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.HandleRequestCallAsync<GetUserClaimsResponse>(request, authenticationData);
        //}

        //public static GetUserClaimsResponse GetUserClaims(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetUserClaims(new GetUserClaimsRequest(), authenticationData);
        //}

        //public static GetUserClaimsResponse GetUserClaims(this RetroAchievementsHttpClient client, GetUserClaimsRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.HandleRequestCall<GetUserClaimsResponse>(request, authenticationData);
        //}
        //#endregion GetUserClaims

        //#region GetUserCompletedGames
        //public static async Task<GetUserCompletedGamesResponse> GetUserCompletedGamesAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetUserCompletedGamesAsync(new GetUserCompletedGamesRequest(), authenticationData);
        //}

        //public static async Task<GetUserCompletedGamesResponse> GetUserCompletedGamesAsync(this RetroAchievementsHttpClient client, GetUserCompletedGamesRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.HandleRequestCallAsync<GetUserCompletedGamesResponse>(request, authenticationData);
        //}

        //public static GetUserCompletedGamesResponse GetUserCompletedGames(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetUserCompletedGames(new GetUserCompletedGamesRequest(), authenticationData);
        //}

        //public static GetUserCompletedGamesResponse GetUserCompletedGames(this RetroAchievementsHttpClient client, GetUserCompletedGamesRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.HandleRequestCall<GetUserCompletedGamesResponse>(request, authenticationData);
        //}
        //#endregion GetUserCompletedGames

        //#region GetUserGameRankAndScore
        //public static async Task<GetUserGameRankAndScoreResponse> GetUserGameRankAndScoreAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetUserGameRankAndScoreAsync(new GetUserGameRankAndScoreRequest(), authenticationData);
        //}

        //public static async Task<GetUserGameRankAndScoreResponse> GetUserGameRankAndScoreAsync(this RetroAchievementsHttpClient client, GetUserGameRankAndScoreRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.HandleRequestCallAsync<GetUserGameRankAndScoreResponse>(request, authenticationData);
        //}

        //public static GetUserGameRankAndScoreResponse GetUserGameRankAndScore(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetUserGameRankAndScore(new GetUserGameRankAndScoreRequest(), authenticationData);
        //}

        //public static GetUserGameRankAndScoreResponse GetUserGameRankAndScore(this RetroAchievementsHttpClient client, GetUserGameRankAndScoreRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.HandleRequestCall<GetUserGameRankAndScoreResponse>(request, authenticationData);
        //}
        //#endregion GetUserGameRankAndScore

        //#region GetUserPoints
        //public static async Task<GetUserPointsResponse> GetUserPointsAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetUserPointsAsync(new GetUserPointsRequest(), authenticationData);
        //}

        //public static async Task<GetUserPointsResponse> GetUserPointsAsync(this RetroAchievementsHttpClient client, GetUserPointsRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.HandleRequestCallAsync<GetUserPointsResponse>(request, authenticationData);
        //}

        //public static GetUserPointsResponse GetUserPoints(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetUserPoints(new GetUserPointsRequest(), authenticationData);
        //}

        //public static GetUserPointsResponse GetUserPoints(this RetroAchievementsHttpClient client, GetUserPointsRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.HandleRequestCall<GetUserPointsResponse>(request, authenticationData);
        //}
        //#endregion GetUserPoints

        //#region GetUserProgress
        //public static async Task<GetUserProgressResponse> GetUserProgressAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetUserProgressAsync(new GetUserProgressRequest(), authenticationData);
        //}

        //public static async Task<GetUserProgressResponse> GetUserProgressAsync(this RetroAchievementsHttpClient client, GetUserProgressRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.HandleRequestCallAsync<GetUserProgressResponse>(request, authenticationData);
        //}

        //public static GetUserProgressResponse GetUserProgress(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetUserProgress(new GetUserProgressRequest(), authenticationData);
        //}

        //public static GetUserProgressResponse GetUserProgress(this RetroAchievementsHttpClient client, GetUserProgressRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.HandleRequestCall<GetUserProgressResponse>(request, authenticationData);
        //}
        //#endregion GetUserProgress

        //#region GetUserRecentAchievements
        //public static async Task<GetUserRecentAchievementsResponse> GetUserRecentAchievementsAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetUserRecentAchievementsAsync(new GetUserRecentAchievementsRequest(), authenticationData);
        //}

        //public static async Task<GetUserRecentAchievementsResponse> GetUserRecentAchievementsAsync(this RetroAchievementsHttpClient client, GetUserRecentAchievementsRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.HandleRequestCallAsync<GetUserRecentAchievementsResponse>(request, authenticationData);
        //}

        //public static GetUserRecentAchievementsResponse GetUserRecentAchievements(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetUserRecentAchievements(new GetUserRecentAchievementsRequest(), authenticationData);
        //}

        //public static GetUserRecentAchievementsResponse GetUserRecentAchievements(this RetroAchievementsHttpClient client, GetUserRecentAchievementsRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.HandleRequestCall<GetUserRecentAchievementsResponse>(request, authenticationData);
        //}
        //#endregion GetUserRecentAchievements

        //#region GetUserRecentlyPlayedGames
        //public static async Task<GetUserRecentlyPlayedGamesResponse> GetUserRecentlyPlayedGamesAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetUserRecentlyPlayedGamesAsync(new GetUserRecentlyPlayedGamesRequest(), authenticationData);
        //}

        //public static async Task<GetUserRecentlyPlayedGamesResponse> GetUserRecentlyPlayedGamesAsync(this RetroAchievementsHttpClient client, GetUserRecentlyPlayedGamesRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.HandleRequestCallAsync<GetUserRecentlyPlayedGamesResponse>(request, authenticationData);
        //}

        //public static GetUserRecentlyPlayedGamesResponse GetUserRecentlyPlayedGames(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetUserRecentlyPlayedGames(new GetUserRecentlyPlayedGamesRequest(), authenticationData);
        //}

        //public static GetUserRecentlyPlayedGamesResponse GetUserRecentlyPlayedGames(this RetroAchievementsHttpClient client, GetUserRecentlyPlayedGamesRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.HandleRequestCall<GetUserRecentlyPlayedGamesResponse>(request, authenticationData);
        //}
        //#endregion GetUserRecentlyPlayedGames

        //#region GetUserSummary
        //public static async Task<GetUserSummaryResponse> GetUserSummaryAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.GetUserSummaryAsync(new GetUserSummaryRequest(), authenticationData);
        //}

        //public static async Task<GetUserSummaryResponse> GetUserSummaryAsync(this RetroAchievementsHttpClient client, GetUserSummaryRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return await client.HandleRequestCallAsync<GetUserSummaryResponse>(request, authenticationData);
        //}

        //public static GetUserSummaryResponse GetUserSummary(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.GetUserSummary(new GetUserSummaryRequest(), authenticationData);
        //}

        //public static GetUserSummaryResponse GetUserSummary(this RetroAchievementsHttpClient client, GetUserSummaryRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        //{
        //    return client.HandleRequestCall<GetUserSummaryResponse>(request, authenticationData);
        //}
        //#endregion GetUserSummary
    }
}
