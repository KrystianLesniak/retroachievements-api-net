using RetroAchievements.Api.Request;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetActiveClaimsRequest : IRequest
    {
        public string RequestEndpoint => "API_GetActiveClaims";

        public GetActiveClaimsRequest()
        {
        }
    }
}
