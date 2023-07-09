using RetroAchievements.Api.Request;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetActiveClaimsRequest : IRetroAchievementsRequest
    {
        public string RequestEndpoint => "API_GetActiveClaims";

        public GetActiveClaimsRequest()
        {
        }
    }
}
