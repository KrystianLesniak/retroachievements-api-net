using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Games;

namespace RetroAchievements.Api.Requests.Games
{
    /// <summary>
    /// Get the hashes linked to a game.
    /// </summary>
    public record GetGameHashesRequest : IRetroAchievementsRequest<GetGameHashesResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetGameHashes";

        ///<inheritdoc cref="GetGameHashesRequest" />
        ///<param name="gameId"><inheritdoc cref="GameId" path="/summary/node()"/></param>
        public GetGameHashesRequest(int gameId)
        {
            GameId = gameId;
        }

        /// <summary>
        /// Unique RetroAchievements identifier of the game.
        /// </summary>
        [ApiInputKey("i")]
        public int GameId { get; init; }
    }
}
