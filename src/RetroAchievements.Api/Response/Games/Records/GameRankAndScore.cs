using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games.Records
{
    /// <summary>
    /// Game Latest Masters or High Scores entries for a game.
    /// </summary>
    public record GameRankAndScore
    {
        /// <summary>
        /// Username of user
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("User")]
        public string Username { get; private set; } = string.Empty;

        /// <summary>
        /// Count of achievements earned by the user for the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumAchievements")]
        public int AchievementsEarnedCount { get; private set; }

        /// <summary>
        /// Number of points earned by the user for the game.
        /// </summary>
        [JsonInclude]
        public int TotalScore { get; private set; }

        /// <summary>
        /// When the user's latest achievement for the game was unlocked
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        [JsonPropertyName("LastAward")]
        public DateTime LastAwardDate { get; private set; }

        /// <summary>
        /// Unique, stable identifier (ULID) of the user.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ULID")]
        public string? Ulid { get; private set; }
    }
}
