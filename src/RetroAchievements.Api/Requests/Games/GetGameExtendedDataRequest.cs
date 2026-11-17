
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
        ///<param name="unofficialAchievements"><inheritdoc cref="AchievementTypesFlag" path="/summary/node()"/></param>
        public GetGameExtendedDataRequest(int gameId, bool unofficialAchievements = false)
        {
            ArgumentNullException.ThrowIfNull(gameId);

            GameId = gameId;
            AchievementTypesFlag = unofficialAchievements ? 5 : 3;
        }

        ///<summary>
        /// Unique RetroAchievements identifier of the game.
        ///</summary>
        [ApiInputKey("i")]
        public int GameId { get; init; }

        /// <summary>
        /// <see langword="true" /> to get unofficial achievements, (Default = <see langword="false" />) to get core achievements.
        /// </summary>
        [ApiInputKey("f")]
        public int AchievementTypesFlag { get; init; }
    }
}
