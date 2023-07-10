using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetUserGameRankAndScoreRequest : IRetroAchievementsRequest<GetUserGameRankAndScoreResponse>
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
