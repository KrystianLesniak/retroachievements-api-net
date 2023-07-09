using RetroAchievements.Api.Request;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetUserCompletedGamesRequest : IRetroAchievementsRequest
    {
        public GetUserCompletedGamesRequest(string username)
        {
            ArgumentNullException.ThrowIfNull(username, nameof(username));

            Username = username;
        }

        public string RequestEndpoint => "API_GetUserCompletedGames";

        [ApiInputKey("u")]
        public string Username { get; init; }
    }
}
