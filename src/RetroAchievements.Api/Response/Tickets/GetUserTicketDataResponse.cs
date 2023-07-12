using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Tickets
{
    public record GetUserTicketDataResponse : RetroAchievementsResponse
    {
        [JsonInclude]
        [JsonPropertyName("User")]
        public string Username { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonPropertyName("Open")]
        public int OpenTicketsCount { get; private set; }

        [JsonInclude]
        [JsonPropertyName("Closed")]
        public int ClosedTicketsCount { get; private set; }

        [JsonInclude]
        [JsonPropertyName("Resolved")]
        public int ResolvedTicketsCount { get; private set; }

        [JsonInclude]
        [JsonPropertyName("Total")]
        public int TotalTicketsCount { get; private set; }

        [JsonInclude]
        [JsonPropertyName("URL")]
        public string Url { get; private set; } = string.Empty;
    }
}
