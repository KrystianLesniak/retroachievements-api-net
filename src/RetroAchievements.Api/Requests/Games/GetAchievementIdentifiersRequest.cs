
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Games;

namespace RetroAchievements.Api.Requests.Games
{
    ///<summary>
    /// Get the achievements associated to a game.
    ///</summary>
    public record GetAchievementIdentifiersRequest : IRetroAchievementsRequest<GetAchievementIdentifiersResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetAchievementCount";


        ///<inheritdoc cref="GetAchievementIdentifiersRequest" />
        ///<param name="gameId"><inheritdoc cref="GameId" path="/summary/node()"/></param>
        public GetAchievementIdentifiersRequest(int gameId)
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
