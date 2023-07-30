using RetroAchievements.Api.Internal.Json.Converters;
using RetroAchievements.Api.Response.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Current achievement of the week data.
    /// </summary>
    public record GetAchievementOfTheWeekResponse : RetroAchievementsResponse
    {
        /// <inheritdoc cref="Response.Records.Achievement"/>
        [JsonInclude]
        public Achievement Achievement { get; private set; } = new();

        /// <inheritdoc cref="Response.Records.Console"/>
        [JsonInclude]
        public Response.Records.Console Console { get; private set; } = new();

        /// <summary>
        /// When the achievement was set as the achievement of the week.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime StartAt { get; private set; }

        /// <summary>
        /// Number of times the achievement has been unlocked.
        /// </summary>
        [JsonInclude]
        public int UnlocksCount { get; private set; }

        /// <summary>
        /// Number of players who have played the game associated to the achievement.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("TotalPlayers")]
        public int TotalPlayersCount { get; private set; }

        /// <summary>
        /// List of achievement unlocks data.
        /// </summary>
        [JsonInclude]
        public IReadOnlyCollection<Unlock> Unlocks { get; private set; } = Array.Empty<Unlock>();
    }
}
