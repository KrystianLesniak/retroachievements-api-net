
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Games;

namespace RetroAchievements.Api.Requests.Games
{
    /// <summary>
    /// Get the overall rating of the game.
    /// </summary>
    public record GetGameRatingRequest : IRetroAchievementsRequest<GetGameRatingResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetGameRating";

        ///<inheritdoc cref="GetGameRatingRequest" />
        ///<param name="gameId"><inheritdoc cref="GameId" path="/summary/node()"/></param>
        public GetGameRatingRequest(int gameId)
        {
            ArgumentNullException.ThrowIfNull(gameId);

            GameId = gameId;
        }

        /// <summary>
        /// Unique identifier of the game
        /// </summary>
        [ApiInputKey("i")]
        public int GameId { get; init; }
    }
}
