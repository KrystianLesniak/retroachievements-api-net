using RetroAchievements.Api.Request;
using RetroAchievements.Api.Requests.Enums;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get data about claims set (max: <see langword="1000"/>), sorted by latest 'Created' date.
    /// </summary>
    public record GetClaimsRequest : IRetroAchievementsRequest<GetClaimsResponse>
    {
        /// <inheritdoc/>
        public string RequestEndpoint => "API_GetClaims";

        ///<inheritdoc cref="GetClaimsRequest" />
        ///<param name="claimKind"><inheritdoc cref="ClaimKind" path="/summary/node()"/></param>
        public GetClaimsRequest(ClaimKind claimKind = ClaimKind.Completed)
        {
            ClaimKind = claimKind;
        }

        /// <summary>
        /// Claim Kind of claims to be returned. (Default = <see cref="ClaimKind.Completed"/>)
        /// </summary>
        [ApiInputKey("k")]
        public ClaimKind ClaimKind { get; init; }
    }

}
