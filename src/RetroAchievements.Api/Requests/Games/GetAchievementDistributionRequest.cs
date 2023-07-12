
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Games;

namespace RetroAchievements.Api.Requests.Games
{
    /// <summary>
    /// Get a mapping of the number of players who have earned each quantity of achievements for a specified Game.
    /// </summary>
    public record GetAchievementDistributionRequest : IRetroAchievementsRequest<GetAchievementDistributionResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetAchievementDistribution";

        ///<inheritdoc cref="GetAchievementIdentifiersRequest" />
        ///<param name="gameId"><inheritdoc cref="GameId" path="/summary/node()"/></param>
        ///<param name="hardcoreOnly"><inheritdoc cref="Hardcore" path="/summary/node()"/></param>
        ///<param name="unofficialAchievements"><inheritdoc cref="AchievementTypesFlag" path="/summary/node()"/></param>
        public GetAchievementDistributionRequest(int gameId, bool hardcoreOnly = false, bool unofficialAchievements = false)
        {
            ArgumentNullException.ThrowIfNull(gameId);

            GameId = gameId;
            Hardcore = hardcoreOnly ? 1 : 0;
            AchievementTypesFlag = unofficialAchievements ? 5 : 3;
        }

        /// <summary>
        ///  Unique RetroAchievements identifier of the game.
        /// </summary>
        [ApiInputKey("i")]
        public int GameId { get; init; }

        /// <summary>
        /// <see langword="true" /> to get only hardcore unlocks, (Default = <see langword="false" />) to get all unlocks.
        /// </summary>
        [ApiInputKey("h")]
        public int Hardcore { get; init; }

        /// <summary>
        /// <see langword="true" /> to get unofficial achievements, (Default = <see langword="false" />) to get core achievements.
        /// </summary>
        [ApiInputKey("f")]
        public int AchievementTypesFlag { get; init; }
    }
}
