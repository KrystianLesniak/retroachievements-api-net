using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetUserRankAndPointsRequest : IRetroAchievementsRequest<GetUserRankAndPointsResponse>
    {
        public GetUserRankAndPointsRequest(string username)
        {
            ArgumentNullException.ThrowIfNull(username, nameof(username));

            Username = username;
        }

        public string RequestEndpoint => "API_GetUserRankAndScore";

        [ApiInputKey("u")]
        public string Username { get; init; }
    }
}
