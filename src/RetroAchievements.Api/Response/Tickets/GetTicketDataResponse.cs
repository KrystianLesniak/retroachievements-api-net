using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Tickets
{
    /// <summary>
    /// Details data about ticket.
    /// </summary>
    public record GetTicketDataResponse : RetroAchievementsResponse
    {
        /// <summary>
        /// Unique identifier of the ticket.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        /// <summary>
        /// Unique identifier of the achievement associated to the ticket.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("AchievementID")]
        public int AchievementId { get; private set; }

        /// <summary>
        /// Title of the achievement.
        /// </summary>
        [JsonInclude]
        public string AchievementTitle { get; private set; } = string.Empty;

        /// <summary>
        /// Description of the achievement.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("AchievementDesc")]
        public string AchievementDescription { get; private set; } = string.Empty;

        /// <summary>
        /// Number of points for the achievement.
        /// </summary>
        [JsonInclude]
        public int Points { get; private set; }

        /// <summary>
        /// Unique identifier of the badge image for the achievement.
        /// </summary>
        [JsonInclude]
        public string BadgeName { get; private set; } = string.Empty;

        /// <summary>
        /// Username of who originally created the achievement.
        /// </summary>
        [JsonInclude]
        public string AchievementAuthor { get; private set; } = string.Empty;

        /// <summary>
        /// Unique identifier of the game associated to the achievement.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("GameID")]
        public int GameId { get; private set; }

        /// <summary>
        /// Title of the game.
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
        /// When the ticket was created.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        [JsonPropertyName("ReportedAt")]
        public DateTime ReportedDate { get; private set; }

        /// <summary>
        /// Unique identifier of the ticket type.
        /// </summary>
        [JsonInclude]
        public int ReportType { get; private set; }

        /// <summary>
        /// Text description of the ticket type.
        /// </summary>
        [JsonInclude]
        public string ReportTypeDescription { get; private set; } = string.Empty;

        /// <summary>
        /// Unique identifier of the ticket state.
        /// </summary>
        [JsonInclude]
        public int ReportState { get; private set; }

        /// <summary>
        /// Text description of the ticket state.
        /// </summary>
        [JsonInclude]
        public string ReportStateDescription { get; private set; } = string.Empty;

        /// <summary>
        /// Is hardcore.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(NumberApiToBooleanConverter))]
        [JsonPropertyName("Hardcore")]
        public bool? IsHardcore { get; private set; }

        /// <summary>
        /// Summary of the problem as reported by the user.
        /// </summary>
        [JsonInclude]
        public string ReportNotes { get; private set; } = string.Empty;

        /// <summary>
        /// User that created the ticket.
        /// </summary>
        [JsonInclude]
        public string ReportedBy { get; private set; } = string.Empty;

        /// <summary>
        /// When the ticket was closed.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        [JsonPropertyName("ResolvedAt")]
        public DateTime ResolvedDate { get; private set; }

        /// <summary>
        /// User that closed the ticket.
        /// </summary>
        [JsonInclude]
        public string ResolvedBy { get; private set; } = string.Empty;

        /// <summary>
        /// URL to the editor for the ticket.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("URL")]
        public string URL { get; private set; } = string.Empty;
    }
}
