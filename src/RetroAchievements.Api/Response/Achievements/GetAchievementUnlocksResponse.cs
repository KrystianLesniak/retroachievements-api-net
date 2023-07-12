using RetroAchievements.Api.Response.Achievements.Records;
using RetroAchievements.Api.Response.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Achievements
{
    /// <summary>
    /// Achievement data about Unlocks
    /// </summary>
    public record GetAchievementUnlocksResponse : RetroAchievementsResponse
    {
        /// <inheritdoc cref="Response.Records.Achievement"/>
        [JsonInclude]
        public Achievement Achievement { get; private set; } = new();

        /// <inheritdoc cref="Response.Records.Console"/>
        [JsonInclude]
        public Response.Records.Console Console { get; private set; } = new();

        /// <inheritdoc cref="AchievementGame"/>
        [JsonInclude]
        public AchievementGame Game { get; private set; } = new();

        /// <summary>
        /// Count of times the achievement has been unlocked.
        /// </summary>
        [JsonInclude]
        public int UnlocksCount { get; private set; }

        /// <summary>
        /// Count of players who have played the game associated to the achievement.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("TotalPlayers")]
        public int PlayersCount { get; private set; }

        /// <summary>
        /// Collection of Unlock data for achievement.
        /// </summary>
        [JsonInclude]
        public IReadOnlyCollection<Unlock> Unlocks { get; private set; } = new List<Unlock>();

    }
}
