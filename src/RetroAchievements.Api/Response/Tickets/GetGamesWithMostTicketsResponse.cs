using RetroAchievements.Api.Response.Tickets.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Tickets
{
    /// <summary>
    /// Games data with most open tickets.
    /// </summary>
    public record GetGamesWithMostTicketsResponse : RetroAchievementsResponse
    {

        /// <summary>
        /// Collection of most reported games.
        /// </summary>
        [JsonInclude]
        public IReadOnlyCollection<Game> MostReportedGames { get; private set; } = Array.Empty<Game>();

        /// <summary>
        /// URL to the list of games with the most tickets.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("URL")]
        public string Url { get; private set; } = string.Empty;
    }
}
