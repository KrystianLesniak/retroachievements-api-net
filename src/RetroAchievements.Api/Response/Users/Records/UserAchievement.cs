using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users.Records
{
    /// <summary>
    /// The achievement earned by the user.
    /// </summary>
    public record UserAchievement
    {
        /// <summary>
        /// When the achievement was earned.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        [JsonPropertyName("Date")]
        public DateTime EarnedDate { get; private set; }

        /// <summary>
        /// Is unlocked in hardcore mode.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(NumberApiToBooleanConverter))]
        public bool HardcoreMode { get; private set; }

        /// <summary>
        /// Unique RetroAchievements identifier of the achievement.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("AchievementID")]
        public int AchievementId { get; private set; }

        /// <summary>
        /// Title of the achievement
        /// </summary>
        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

        /// <summary>
        /// Description of the achievements
        /// </summary>
        [JsonInclude]
        public string Description { get; private set; } = string.Empty;

        /// <summary>
        /// Number of points the achievement is worth.
        /// </summary>
        [JsonInclude]
        public int Points { get; private set; }

        /// <summary>
        /// Unique identifier of the badge image for the achievement.
        /// </summary>
        [JsonInclude]
        public string BadgeName { get; private set; } = string.Empty;

        /// <summary>
        /// Site-relative path to the badge image for the achievement.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("BadgeURL")]
        public string BadgeUrl { get; private set; } = string.Empty;

        /// <summary>
        /// User who originally created the achievement.
        /// </summary>
        [JsonInclude]
        public string Author { get; private set; } = string.Empty;

        /// <summary>
        /// Unique identifier of the game associated to the achievement.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("GameID")]
        public int GameId { get; private set; }

        /// <summary>
        /// Title of the game associated to the achievement.
        /// </summary>
        [JsonInclude]
        public string GameTitle { get; private set; } = string.Empty;

        /// <summary>
        /// Site-relative path to the game's icon image.
        /// </summary>
        [JsonInclude]
        public string GameIcon { get; private set; } = string.Empty;

        /// <summary>
        /// Name of the console associated to the game.
        /// </summary>
        [JsonInclude]
        public string ConsoleName { get; private set; } = string.Empty;

        /// <summary>
        /// Sum of points for all achievements so far (including current).
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("CumulScore")]
        public int ScoreSum { get; private set; }

        /// <summary>
        /// Site-relative path to the game page.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("GameURL")]
        public string GameUrl { get; private set; } = string.Empty;
    }
}
