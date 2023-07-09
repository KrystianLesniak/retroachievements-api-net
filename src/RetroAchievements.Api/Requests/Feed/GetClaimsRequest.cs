using RetroAchievements.Api.Request;
using RetroAchievements.Api.Requests.Enums;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetClaimsRequest : IRetroAchievementsRequest
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
