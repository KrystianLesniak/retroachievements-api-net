using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users.Records
{
    /// <summary>
    /// Information about user earned achievements in specified game.
    /// </summary>
    public class UserProgressAchievement
    {
        /// <summary>
        /// Unique identifier of the achievement.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        /// <summary>
        /// Title of the achievement
        /// </summary>
        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

        /// <summary>
        /// Description of the achievement
        /// </summary>
        [JsonInclude]
        public string Description { get; private set; } = string.Empty;

        /// <summary>
        /// Number of points the achievement is worth.
        /// </summary>
        [JsonInclude]
        public int Points { get; private set; }

        /// <summary>
        /// Number of "white" points the achievement is worth.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("TrueRatio")]
        public int TrueRatioPoints { get; private set; }

        /// <summary>
        /// Unique identifier of the badge image for the achievement.
        /// </summary>
        [JsonInclude]
        public string BadgeName { get; private set; } = string.Empty;

        /// <summary>
        ///  Number of times the achievement has been awarded.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumAwarded")]
        public int AwardedCount { get; private set; }

        /// <summary>
        ///  Number of times the achievement has been awarded in hardcore.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumAwardedHardcore")]
        public int AwardedHardcoreCount { get; private set; }

        /// <summary>
        /// Field used for determining which order to display the achievements.
        /// </summary>
        [JsonInclude]
        public int DisplayOrder { get; private set; }

        /// <summary>
        /// User who first created the achievement.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("Author")]
        public string AuthorUsername { get; private set; } = string.Empty;

        /// <summary>
        /// When the achievement was created.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime DateCreated { get; private set; }

        /// <summary>
        /// When the achievement was last modified.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime DateModified { get; private set; }

        /// <summary>
        /// MD5 of the logic for the achievement.
        /// </summary>
        [JsonInclude]
        public string MemAddr { get; private set; } = string.Empty;

        /// <summary>
        /// When the achievement was earned.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        [JsonPropertyName("DateEarned")]
        public DateTime EarnedDate { get; private set; }

        /// <summary>
        /// When the achievement was earned in hardcore.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        [JsonPropertyName("DateEarnedHardcore")]
        public DateTime EarnedHardcoreDate { get; private set; }
    }
}