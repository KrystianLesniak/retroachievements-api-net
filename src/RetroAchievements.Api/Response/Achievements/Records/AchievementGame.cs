using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Achievements.Records
{
    /// <summary>
    /// Information about the game associated to the achievement.
    /// </summary>
    public record AchievementGame
    {
        /// <summary>
        /// Unique identifier of the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        /// <summary>
        /// Title of the game.
        /// </summary>
        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

    }
}
