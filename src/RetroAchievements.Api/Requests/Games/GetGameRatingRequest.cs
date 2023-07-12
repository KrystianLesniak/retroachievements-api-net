
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Games;

namespace RetroAchievements.Api.Requests.Games
{
    public record GetGameRatingRequest : IRetroAchievementsRequest<GetGameRatingResponse>
    {
        public string RequestEndpoint => "API_GetGameRating";

        public GetGameRatingRequest(int gameId)
        {
            ArgumentNullException.ThrowIfNull(gameId);

            GameId = gameId;
        }

        [ApiInputKey("i")]
        public int GameId { get; init; }
    }
}
