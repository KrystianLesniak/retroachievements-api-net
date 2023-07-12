using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Tickets
{
    public record GetTicketDataResponse : RetroAchievementsResponse
    {
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        [JsonInclude]
        [JsonPropertyName("AchievementID")]
        public int AchievementId { get; private set; }

        [JsonInclude]
        public string AchievementTitle { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonPropertyName("AchievementDesc")]
        public string AchievementDescription { get; private set; } = string.Empty;

        [JsonInclude]
        public int Points { get; private set; }

        [JsonInclude]
        public string BadgeName { get; private set; } = string.Empty;

        [JsonInclude]
        public string AchievementAuthor { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonPropertyName("GameID")]
        public int GameId { get; private set; }

        [JsonInclude]
        public string GameTitle { get; private set; } = string.Empty;

        [JsonInclude]
        public string GameIcon { get; private set; } = string.Empty;

        [JsonInclude]
        public string ConsoleName { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        [JsonPropertyName("ReportedAt")]
        public DateTime ReportedDate { get; private set; }

        [JsonInclude]
        public int ReportType { get; private set; }

        [JsonInclude]
        public string ReportTypeDescription { get; private set; } = string.Empty;

        [JsonInclude]
        public int ReportState { get; private set; }

        [JsonInclude]
        public string ReportStateDescription { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonConverter(typeof(NumberApiToBooleanConverter))]
        [JsonPropertyName("Hardcore")]
        public bool? IsHardcore { get; private set; }

        [JsonInclude]
        public string ReportNotes { get; private set; } = string.Empty;

        [JsonInclude]
        public string ReportedBy { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        [JsonPropertyName("ResolvedAt")]
        public DateTime ResolvedDate { get; private set; }

        [JsonInclude]
        public string ResolvedBy { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonPropertyName("URL")]

        public string URL { get; private set; } = string.Empty;
    }
}
