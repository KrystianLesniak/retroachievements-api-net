using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users.Records
{
    /// <summary>
    /// Game High Score data for user.
    /// </summary>
    public record GameRankAndScore
    {
        /// <summary>
        /// Username of user.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("User")]
        public string Username { get; private set; } = string.Empty;

        /// <summary>
        /// Total number of points earned by the user for the game.
        /// </summary>
        [JsonInclude]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int TotalScore { get; private set; }

        /// <summary>
        /// When the last achievement was unlocked for the user.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        [JsonPropertyName("LastAward")]
        public DateTime LastAwardDate { get; private set; }

        /// <summary>
        /// Position of user on the game's High Scores list.
        /// </summary>
        [JsonInclude]
        public int? UserRank { get; private set; }

    }
}
