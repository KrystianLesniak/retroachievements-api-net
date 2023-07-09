using RetroAchievements.Api.Request;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetUserGameRankAndScoreRequest : IRetroAchievementsRequest
    {
        public GetUserGameRankAndScoreRequest(string username, int gameId)
        {
            ArgumentNullException.ThrowIfNull(username, nameof(username));

            Username = username;
            GameId = gameId;
        }

        public string RequestEndpoint => "API_GetUserGameRankAndScore";

        [ApiInputKey("g")]
        public int GameId { get; init; }

        [ApiInputKey("u")]
        public string Username { get; init; }
    }
}
