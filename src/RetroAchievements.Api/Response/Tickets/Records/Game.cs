using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Tickets.Records
{
    public record Game
    {
        [JsonInclude]
        [JsonPropertyName("GameID")]
        public int GameId { get; private set; }

        [JsonInclude]
        public string GameTitle { get; private set; } = string.Empty;

        [JsonInclude]
        public string GameIcon { get; private set; } = string.Empty;

        [JsonInclude]
        public string Console { get; private set; } = string.Empty;

        [JsonInclude]
        public int OpenTickets { get; private set; }

    }
}
