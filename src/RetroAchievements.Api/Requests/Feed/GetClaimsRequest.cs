using RetroAchievements.Api.Request;
using RetroAchievements.Api.Requests.Enums;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// TODO:
    /// </summary>
    public record GetClaimsRequest : IRetroAchievementsRequest<GetClaimsResponse>
    {
        public string RequestEndpoint => "API_GetClaims";

        public GetClaimsRequest(ClaimKind claimKind = ClaimKind.Completed)
        {
            ClaimKind = claimKind;
        }

        [ApiInputKey("k")]
        public ClaimKind ClaimKind { get; init; }
    }

}
