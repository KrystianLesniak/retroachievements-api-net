using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Set requests made by the user.
    /// </summary>
    public record GetUserSetRequestsResponse : RetroAchievementsResponse
    {
        /// <summary>
        /// Collection of requested sets.
        /// </summary>
        [JsonInclude]
        public IReadOnlyCollection<SetRequest> RequestedSets { get; private set; } = Array.Empty<SetRequest>();

        /// <summary>
        /// Total number of set requests the user can make.
        /// </summary>
        [JsonInclude]
        public int TotalRequests { get; private set; }

        /// <summary>
        /// Number of points the user needs to earn another set request.
        /// </summary>
        [JsonInclude]
        public int PointsForNext { get; private set; }
    }

    /// <summary>
    /// Data about the requested set.
    /// </summary>
    public record SetRequest
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
        public string Title { get; private set; } = string.Empty;

        /// <summary>
        /// Unique identifier of the console.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ConsoleID")]
        public int ConsoleId { get; private set; }

        /// <summary>
        /// Name of the console.
        /// </summary>
        [JsonInclude]
        public string ConsoleName { get; private set; } = string.Empty;

        /// <summary>
        /// Site-relative path to the game's icon image.
        /// </summary>
        [JsonInclude]
        public string ImageIcon { get; private set; } = string.Empty;
    }
}
