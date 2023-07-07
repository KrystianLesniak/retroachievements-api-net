using RetroAchievements.Api.Requests.Enums;
using RetroAchievements.Api.Requests.Users;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api
{
    public static class FeedApi
    {
        #region GetAchievementOfTheWeek
        public static async Task<GetAchievementOfTheWeekResponse> GetAchievementOfTheWeekAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.GetAchievementOfTheWeekAsync(new GetAchievementOfTheWeekRequest(), authenticationData);
        }

        public static async Task<GetAchievementOfTheWeekResponse> GetAchievementOfTheWeekAsync(this RetroAchievementsHttpClient client, GetAchievementOfTheWeekRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.HandleRequestCallAsync<GetAchievementOfTheWeekResponse>(request, authenticationData);
        }

        public static GetAchievementOfTheWeekResponse GetAchievementOfTheWeek(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.GetAchievementOfTheWeek(new GetAchievementOfTheWeekRequest(), authenticationData);
        }

        public static GetAchievementOfTheWeekResponse GetAchievementOfTheWeek(this RetroAchievementsHttpClient client, GetAchievementOfTheWeekRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.HandleRequestCall<GetAchievementOfTheWeekResponse>(request, authenticationData);
        }
        #endregion GetAchievementOfTheWeek

        #region GetActiveClaims
        public static async Task<GetActiveClaimsResponse> GetActiveClaimsAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.GetActiveClaimsAsync(new GetActiveClaimsRequest(), authenticationData);
        }

        public static async Task<GetActiveClaimsResponse> GetActiveClaimsAsync(this RetroAchievementsHttpClient client, GetActiveClaimsRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.HandleRequestCallAsync<GetActiveClaimsResponse>(request, authenticationData);
        }

        public static GetActiveClaimsResponse GetActiveClaims(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.GetActiveClaims(new GetActiveClaimsRequest(), authenticationData);
        }

        public static GetActiveClaimsResponse GetActiveClaims(this RetroAchievementsHttpClient client, GetActiveClaimsRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.HandleRequestCall<GetActiveClaimsResponse>(request, authenticationData);
        }
        #endregion GetActiveClaims

        #region GetClaims
        public static async Task<GetClaimsResponse> GetClaimsAsync(this RetroAchievementsHttpClient client, ClaimKind claimKind = ClaimKind.Completed, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.GetClaimsAsync(new GetClaimsRequest(claimKind), authenticationData);
        }

        public static async Task<GetClaimsResponse> GetClaimsAsync(this RetroAchievementsHttpClient client, GetClaimsRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.HandleRequestCallAsync<GetClaimsResponse>(request, authenticationData);
        }

        public static GetClaimsResponse GetClaims(this RetroAchievementsHttpClient client, ClaimKind claimKind = ClaimKind.Completed, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.GetClaims(new GetClaimsRequest(claimKind), authenticationData);
        }

        public static GetClaimsResponse GetClaims(this RetroAchievementsHttpClient client, GetClaimsRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.HandleRequestCall<GetClaimsResponse>(request, authenticationData);
        }
        #endregion GetClaims

        #region GetTopTenUsers
        public static async Task<GetTopTenUsersResponse> GetTopTenUsersAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.GetTopTenUsersAsync(new GetTopTenUsersRequest(), authenticationData);
        }

        public static async Task<GetTopTenUsersResponse> GetTopTenUsersAsync(this RetroAchievementsHttpClient client, GetTopTenUsersRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.HandleRequestCallAsync<GetTopTenUsersResponse>(request, authenticationData);
        }

        public static GetTopTenUsersResponse GetTopTenUsers(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.GetTopTenUsers(new GetTopTenUsersRequest(), authenticationData);
        }

        public static GetTopTenUsersResponse GetTopTenUsers(this RetroAchievementsHttpClient client, GetTopTenUsersRequest request, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.HandleRequestCall<GetTopTenUsersResponse>(request, authenticationData);
        }
        #endregion GetTopTenUsers
    }
}
