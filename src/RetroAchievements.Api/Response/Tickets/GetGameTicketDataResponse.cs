using RetroAchievements.Api.Response.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Tickets
{
    public record GetGameTicketDataResponse : RetroAchievementsResponse
    {
        [JsonInclude]
        [JsonPropertyName("GameID")]
        public int GameId { get; private set; }

        [JsonInclude]
        public string GameTitle { get; private set; } = string.Empty;

        [JsonInclude]
        public string ConsoleName { get; private set; } = string.Empty;

        [JsonInclude]
        public int OpenTickets { get; private set; }

        [JsonInclude]
        [JsonPropertyName("URL")]
        public string Url { get; private set; } = string.Empty;

        [JsonInclude]
        public IEnumerable<Ticket> Tickets { get; private set; } = new List<Ticket>();

    }
}
