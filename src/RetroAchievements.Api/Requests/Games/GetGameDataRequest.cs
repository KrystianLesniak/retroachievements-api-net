
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Games;

namespace RetroAchievements.Api.Requests.Games
{
    /// <summary>
    /// Return information data about the game.
    /// </summary>
    public record GetGameDataRequest : IRetroAchievementsRequest<GetGameDataResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetGame";

        ///<inheritdoc cref="GetGameDataRequest" />
        ///<param name="gameId"><inheritdoc cref="GameId" path="/summary/node()"/></param>
        public GetGameDataRequest(int gameId)
        {
            ArgumentNullException.ThrowIfNull(gameId);

            GameId = gameId;
        }

        ///<summary>
        /// Unique RetroAchievements identifier of the game.
        ///</summary>
        [ApiInputKey("i")]
        public int GameId { get; init; }
    }
}
