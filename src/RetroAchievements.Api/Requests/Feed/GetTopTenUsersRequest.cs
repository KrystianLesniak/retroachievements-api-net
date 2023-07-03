using RetroAchievements.Api.Request;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetTopTenUsersRequest : IRequest
    {
        public string RequestEndpoint => "API_GetTopTenUsers";

        public GetTopTenUsersRequest()
        {
        }
    }
}
