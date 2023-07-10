using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetActiveClaimsRequest : IRetroAchievementsRequest<GetActiveClaimsResponse>
    {
        public string RequestEndpoint => "API_GetActiveClaims";

        public GetActiveClaimsRequest()
        {
        }
    }
}
