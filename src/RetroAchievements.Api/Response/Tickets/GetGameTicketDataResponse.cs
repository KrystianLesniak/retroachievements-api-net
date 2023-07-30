using RetroAchievements.Api.Response.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Tickets
{
    /// <summary>
    /// Ticket data for specific game.
    /// </summary>
    public record GetGameTicketDataResponse : RetroAchievementsResponse
    {
        /// <summary>
        /// Unique identifier of the game
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
        /// Name of the console.
        /// </summary>
        [JsonInclude]
        public string ConsoleName { get; private set; } = string.Empty;

        /// <summary>
        /// Count of open tickets.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("OpenTickets")]
        public int OpenTicketsCount { get; private set; }

        /// <summary>
        /// URL to the list of tickets associated to the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("URL")]
        public string Url { get; private set; } = string.Empty;

        /// <summary>
        /// Collection of details on open tickets.
        /// </summary>
        [JsonInclude]
        public IReadOnlyCollection<Ticket> Tickets { get; private set; } = Array.Empty<Ticket>();

    }
}
