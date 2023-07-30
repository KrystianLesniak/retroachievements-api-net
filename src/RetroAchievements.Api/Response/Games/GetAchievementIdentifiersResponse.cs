using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games
{
    /// <summary>
    /// List of Achievement unique identifiers associated to game with identifier <see cref="GameId"/>
    /// </summary>
    public record GetAchievementIdentifiersResponse : RetroAchievementsResponse
    {
        /// <summary>
        /// RetroAchievements Identifier of the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("GameID")]
        public int GameId { get; private set; }

        /// <summary>
        /// List of RetroAchievements Identifiers of the achievement.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("AchievementIDs")]
        public IReadOnlyCollection<int> AchievementIds { get; private set; } = Array.Empty<int>();
    }
}
