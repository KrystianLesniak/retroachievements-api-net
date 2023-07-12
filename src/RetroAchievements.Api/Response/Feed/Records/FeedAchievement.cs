using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Feed.Records
{
    /// <summary>
    /// Data about the achievement.
    /// </summary>
    public record FeedAchievement
    {
        /// <summary>
        /// Unique identifier of the achievement.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        /// <summary>
        /// Title of the achievement.
        /// </summary>
        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

        /// <summary>
        /// Description of the achievement.
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
    }
}
