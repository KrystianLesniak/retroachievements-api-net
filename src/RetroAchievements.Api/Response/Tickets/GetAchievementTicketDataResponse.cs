using RetroAchievements.Api.Response.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Tickets
{
    public record GetAchievementTicketDataResponse : RetroAchievementsResponse
    {
        [JsonInclude]
        [JsonPropertyName("AchievementID")]
        public int AchievementId { get; private set; }

        [JsonInclude]
        public string AchievementTitle { get; private set; } = string.Empty;

        [JsonInclude]
        public string AchievementDescription { get; private set; } = string.Empty;

        [JsonInclude]
        public int OpenTickets { get; private set; }

        [JsonInclude]
        [JsonPropertyName("URL")]
        public string Url { get; private set; } = string.Empty;

    }
}
