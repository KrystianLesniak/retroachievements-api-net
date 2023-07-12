using RetroAchievements.Api.Response.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Tickets
{
    public record GetOpenTicketsResponse : RetroAchievementsResponse
    {

        [JsonInclude]
        public IReadOnlyCollection<Ticket> RecentTickets { get; private set; } = new List<Ticket>();

        [JsonInclude]
        [JsonPropertyName("OpenTickets")]
        public int OpenTicketsCount { get; private set; }

        [JsonInclude]
        [JsonPropertyName("URL")]
        public string Url { get; private set; } = string.Empty;
    }
}
