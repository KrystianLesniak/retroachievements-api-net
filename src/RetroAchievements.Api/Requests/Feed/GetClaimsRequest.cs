using RetroAchievements.Api.Common.Enums;
using RetroAchievements.Api.Request;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetClaimsRequest : IRequest
    {
        public string RequestEndpoint => "API_GetClaims";

        public GetClaimsRequest(ClaimKindEnum claimKind = ClaimKindEnum.Completed)
        {
            ClaimKind = claimKind;
        }

        [ApiInputKey("k")]
        public ClaimKindEnum ClaimKind { get; init; }
    }

}
