using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetTopTenUsersRequest : IRetroAchievementsRequest<GetTopTenUsersResponse>
    {
        public string RequestEndpoint => "API_GetTopTenUsers";

        public GetTopTenUsersRequest()
        {
        }
    }
}
