using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Records
{
    /// <summary>
    /// Achievement unlock data.
    /// </summary>
    public record Unlock
    {
        /// <summary>
        /// User who unlocked the achievement.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("User")]
        public string Username { get; private set; } = string.Empty;

        /// <summary>
        /// Number of RetroAchievements points the user has.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("RAPoints")]
        public int Points { get; private set; }

        /// <summary>
        /// When the achievement was unlocked.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime DateAwarded { get; private set; }

        /// <summary>
        /// Is unlocked in hardcore mode.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(NumberApiToBooleanConverter))]
        public bool HardcoreMode { get; private set; }
    }
}