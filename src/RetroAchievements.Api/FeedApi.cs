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
            return await client.SendAsync(new GetAchievementOfTheWeekRequest(), authenticationData);
        }
        public static GetAchievementOfTheWeekResponse GetAchievementOfTheWeek(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetAchievementOfTheWeekRequest(), authenticationData);
        }
        #endregion GetAchievementOfTheWeek

        #region GetActiveClaims
        public static async Task<GetActiveClaimsResponse> GetActiveClaimsAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetActiveClaimsRequest(), authenticationData);
        }

        public static GetActiveClaimsResponse GetActiveClaims(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetActiveClaimsRequest(), authenticationData);
        }
        #endregion GetActiveClaims

        #region GetClaims
        public static async Task<GetClaimsResponse> GetClaimsAsync(this RetroAchievementsHttpClient client, ClaimKind claimKind = ClaimKind.Completed, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetClaimsRequest(claimKind), authenticationData);
        }

        public static GetClaimsResponse GetClaims(this RetroAchievementsHttpClient client, ClaimKind claimKind = ClaimKind.Completed, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetClaimsRequest(claimKind), authenticationData);
        }
        #endregion GetClaims

        #region GetTopTenUsers
        public static async Task<GetTopTenUsersResponse> GetTopTenUsersAsync(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetTopTenUsersRequest(), authenticationData);
        }

        public static GetTopTenUsersResponse GetTopTenUsers(this RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetTopTenUsersRequest(), authenticationData);
        }
        #endregion GetTopTenUsers
    }
}
