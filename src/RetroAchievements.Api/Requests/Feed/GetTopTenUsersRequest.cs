using RetroAchievements.Api.Request;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetTopTenUsersRequest : IRetroAchievementsRequest
    {
        public string RequestEndpoint => "API_GetTopTenUsers";

        public GetTopTenUsersRequest()
        {
        }
    }
}
