using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Consoles.Records
{
    /// <summary>
    /// Game associated to the console
    /// </summary>
    public record Game
    {
        /// <summary>
        /// Unique identifier of the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        /// <summary>
        /// Name of the game.
        /// </summary>
        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

        /// <summary>
        /// Unique identifier of the console.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ConsoleID")]
        public int ConsoleId { get; private set; }

        /// <summary>
        /// Name of the console
        /// </summary>
        [JsonInclude]
        public string ConsoleName { get; private set; } = string.Empty;

        /// <summary>
        /// Site-relative path to the game's icon image.
        /// </summary>
        [JsonInclude]
        public string ImageIcon { get; private set; } = string.Empty;

        /// <summary>
        /// Count of core achievements for the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumAchievements")]
        public int AchievementsCount { get; private set; }

        /// <summary>
        /// Count of leaderboards for the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumLeaderboards")]
        public int LeaderboardsCount { get; private set; }

        /// <summary>
        /// Total number of points the game's achievements are worth
        /// </summary>
        [JsonInclude]
        public int Points { get; private set; }

        /// <summary>
        /// when the last modification was made.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime? DateModified { get; private set; }

        /// <summary>
        /// Unique identifier of the official forum topic for the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ForumTopicID")]
        public int? ForumTopicId { get; private set; }

        /// <summary>
        /// List of RetroAchievements hashes associated to the game.
        /// </summary>
        public IReadOnlyCollection<string> Hashes { get; private set; } = new List<string>();
    }
}
