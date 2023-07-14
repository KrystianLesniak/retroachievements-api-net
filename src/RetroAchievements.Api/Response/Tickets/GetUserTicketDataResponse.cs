using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Tickets
{
    /// <summary>
    /// Ticket statistics data for the specified user.
    /// </summary>
    public record GetUserTicketDataResponse : RetroAchievementsResponse
    {
        /// <summary>
        /// Username of the user.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("User")]
        public string Username { get; private set; } = string.Empty;

        /// <summary>
        /// Count of open tickets.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("Open")]
        public int OpenTicketsCount { get; private set; }

        /// <summary>
        /// Count of closed tickets.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("Closed")]
        public int ClosedTicketsCount { get; private set; }

        /// <summary>
        /// Count of resolved tickets.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("Resolved")]
        public int ResolvedTicketsCount { get; private set; }

        /// <summary>
        /// Count of tickets.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("Total")]
        public int TotalTicketsCount { get; private set; }

        /// <summary>
        /// URL to the list of tickets associated to achievements created by the user.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("URL")]
        public string Url { get; private set; } = string.Empty;
    }
}
