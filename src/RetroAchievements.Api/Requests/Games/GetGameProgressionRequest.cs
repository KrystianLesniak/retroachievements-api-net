using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Games;

namespace RetroAchievements.Api.Requests.Games
{
    /// <summary>
    /// Get information about the average time to unlock achievements in a game.
    /// </summary>
    public record GetGameProgressionRequest : IRetroAchievementsRequest<GetGameProgressionResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetGameProgression";

        ///<inheritdoc cref="GetGameProgressionRequest" />
        ///<param name="gameId"><inheritdoc cref="GameId" path="/summary/node()"/></param>
        ///<param name="hardcore"><inheritdoc cref="Hardcore" path="/summary/node()"/></param>
        public GetGameProgressionRequest(int gameId, bool hardcore = false)
        {
            GameId = gameId;
            Hardcore = hardcore ? 1 : 0;
        }

        /// <summary>
        /// Unique RetroAchievements identifier of the game.
        /// </summary>
        [ApiInputKey("i")]
        public int GameId { get; init; }

        /// <summary>
        /// <see langword="true" /> to prefer hardcore unlocks, (Default = <see langword="false" />) to use all unlocks.
        /// </summary>
        [ApiInputKey("h")]
        public int Hardcore { get; init; }
    }
}
