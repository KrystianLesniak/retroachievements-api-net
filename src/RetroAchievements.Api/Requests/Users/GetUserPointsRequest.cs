using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetUserPointsRequest : IRetroAchievementsRequest<GetUserPointsResponse>
    {
        public GetUserPointsRequest(string username)
        {
            ArgumentNullException.ThrowIfNull(username, nameof(username));

            Username = username;
        }

        public string RequestEndpoint => "API_GetUserPoints";

        [ApiInputKey("u")]
        public string Username { get; init; }
    }
}
