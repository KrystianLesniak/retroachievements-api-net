using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Tickets.Records
{
    /// <summary>
    /// Information data about game and ticket statistic.
    /// </summary>
    public record Game
    {
        /// <summary>
        /// Unique identifier of the game.
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
        /// Site-relative path to the game's icon image.
        /// </summary>
        [JsonInclude]
        public string GameIcon { get; private set; } = string.Empty;

        /// <summary>
        /// Name of the console associated to the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("Console")]
        public string ConsoleName { get; private set; } = string.Empty;

        /// <summary>
        /// Count of open tickets associated to the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("OpenTickets")]
        public int OpenTicketsCount { get; private set; }

    }
}
