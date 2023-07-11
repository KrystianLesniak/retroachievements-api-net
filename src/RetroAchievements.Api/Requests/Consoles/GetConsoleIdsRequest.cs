using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Consoles;

namespace RetroAchievements.Api.Requests.Consoles
{
    public record GetConsoleIdsRequest : IRetroAchievementsRequest<GetConsoleIdsResponse>
    {
        public string RequestEndpoint => "API_GetConsoleIDs";

        public GetConsoleIdsRequest()
        {
        }
    }
}
