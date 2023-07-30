using RetroAchievements.Api.Response.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Tickets
{
    /// <summary>
    /// Open tickets data.
    /// </summary>
    public record GetOpenTicketsResponse : RetroAchievementsResponse
    {

        /// <summary>
        /// Recent open tickets collection.
        /// </summary>
        [JsonInclude]
        public IReadOnlyCollection<Ticket> RecentTickets { get; private set; } = Array.Empty<Ticket>();

        /// <summary>
        /// Count of open tickets.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("OpenTickets")]
        public int OpenTicketsCount { get; private set; }

        /// <summary>
        /// URL to the list of open tickets.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("URL")]
        public string Url { get; private set; } = string.Empty;
    }
}
