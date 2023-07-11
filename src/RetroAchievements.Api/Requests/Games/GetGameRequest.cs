
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Games;

namespace RetroAchievements.Api.Requests.Games
{
    public record GetGameRequest : IRetroAchievementsRequest<GetGameResponse>
    {
        public string RequestEndpoint => "API_GetGame";

        public GetGameRequest(int gameId)
        {
            ArgumentNullException.ThrowIfNull(gameId);

            GameId = gameId;
        }

        [ApiInputKey("i")]
        public int GameId { get; init; }
    }
}
