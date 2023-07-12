using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Tickets
{
    public record GetUserTicketDataResponse : RetroAchievementsResponse
    {
        [JsonInclude]
        public string User { get; private set; } = string.Empty;

        [JsonInclude]
        public int Open { get; private set; }

        [JsonInclude]
        public int Closed { get; private set; }

        [JsonInclude]
        public int Resolved { get; private set; }

        [JsonInclude]
        public int Total { get; private set; }

        [JsonInclude]
        [JsonPropertyName("URL")]
        public string Url { get; private set; } = string.Empty;
    }
}
