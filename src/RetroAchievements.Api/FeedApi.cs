﻿using RetroAchievements.Api.Requests.Enums;
using RetroAchievements.Api.Requests.Users;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api
{
    /// <summary>
    /// Class with extension methods for calling APIs from group "Feed"
    /// </summary>
    public static class FeedApi
    {
        #region GetAchievementOfTheWeek
        /// <inheritdoc cref="GetAchievementOfTheWeekRequest()"/>
        public static async Task<GetAchievementOfTheWeekResponse> GetAchievementOfTheWeekAsync(this IRetroAchievementsHttpClient client, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetAchievementOfTheWeekRequest(), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetAchievementOfTheWeekRequest()"/>
        public static GetAchievementOfTheWeekResponse GetAchievementOfTheWeek(this IRetroAchievementsHttpClient client, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetAchievementOfTheWeekRequest(), authenticationData);
        }
        #endregion GetAchievementOfTheWeek

        #region GetActiveClaims
        /// <inheritdoc cref="GetActiveClaimsRequest()"/>
        public static async Task<GetActiveClaimsResponse> GetActiveClaimsAsync(this IRetroAchievementsHttpClient client, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetActiveClaimsRequest(), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetActiveClaimsRequest()"/>
        public static GetActiveClaimsResponse GetActiveClaims(this IRetroAchievementsHttpClient client, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetActiveClaimsRequest(), authenticationData);
        }
        #endregion GetActiveClaims

        #region GetClaims
        /// <inheritdoc cref="GetClaimsRequest(ClaimKind)"/>
        public static async Task<GetClaimsResponse> GetClaimsAsync(this IRetroAchievementsHttpClient client, ClaimKind claimKind = ClaimKind.Completed, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetClaimsRequest(claimKind), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetClaimsRequest(ClaimKind)"/>
        public static GetClaimsResponse GetClaims(this IRetroAchievementsHttpClient client, ClaimKind claimKind = ClaimKind.Completed, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetClaimsRequest(claimKind), authenticationData);
        }
        #endregion GetClaims

        #region GetTopTenUsers
        /// <inheritdoc cref="GetTopTenUsersRequest()"/>
        public static async Task<GetTopTenUsersResponse> GetTopTenUsersAsync(this IRetroAchievementsHttpClient client, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetTopTenUsersRequest(), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetTopTenUsersRequest()"/>
        public static GetTopTenUsersResponse GetTopTenUsers(this IRetroAchievementsHttpClient client, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetTopTenUsersRequest(), authenticationData);
        }
        #endregion GetTopTenUsers
    }
}
