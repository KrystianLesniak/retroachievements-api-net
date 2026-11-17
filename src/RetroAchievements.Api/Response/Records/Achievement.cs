using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Records
{
    /// <summary>
    /// Data about the achievement.
    /// </summary>
    public record Achievement
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

        /// <summary>
        /// Unique, stable identifier (ULID) of the user who first created the achievement.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("AuthorULID")]
        public string? AuthorUlid { get; private set; }

        /// <summary>
        /// Type of the achievement (<see langword="progression"/>, <see langword="win_condition"/>, <see langword="missable"/> or <see langword="null"/>).
        /// </summary>
        [JsonInclude]
        public string? Type { get; private set; }

        /// <summary>
        /// Unique identifier of the badge image for the achievement.
        /// </summary>
        [JsonInclude]
        public string? BadgeName { get; private set; }

        /// <summary>
        /// Site-relative path to the achievement's badge image.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("BadgeURL")]
        public string? BadgeUrl { get; private set; }
    }
}
