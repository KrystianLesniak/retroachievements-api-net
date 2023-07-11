using RetroAchievements.Api.Response.Records;
using RetroAchievements.Api.Response.Tickets.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Tickets
{
    public record GetGamesWithMostTicketsResponse : RetroAchievementsResponse
    {

        [JsonInclude]
        public IEnumerable<Game> MostReportedGames { get; private set; } = new List<Game>();

        [JsonInclude]
        [JsonPropertyName("URL")]
        public string Url { get; private set; } = string.Empty;
    }
}
