
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Games;

namespace RetroAchievements.Api.Requests.Games
{
    public record GetGameExtendedRequest : IRetroAchievementsRequest<GetGameExtendedResponse>
    {
        public string RequestEndpoint => "API_GetGameExtended";

        public GetGameExtendedRequest(int gameId)
        {
            ArgumentNullException.ThrowIfNull(gameId);

            GameId = gameId;
        }

        [ApiInputKey("i")]
        public int GameId { get; init; }

    }
}
