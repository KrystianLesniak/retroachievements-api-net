
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Games;

namespace RetroAchievements.Api.Requests.Games
{
    /// <summary>
    /// Get extended information data about the game.
    /// </summary>
    public record GetGameExtendedDataRequest : IRetroAchievementsRequest<GetGameExtendedDataResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetGameExtended";

        ///<inheritdoc cref="GetGameExtendedDataRequest" />
        ///<param name="gameId"><inheritdoc cref="GameId" path="/summary/node()"/></param>
        public GetGameExtendedDataRequest(int gameId)
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
