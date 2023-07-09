using RetroAchievements.Api.Request;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetUserPointsRequest : IRetroAchievementsRequest
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
