using RetroAchievements.Api.Response;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Paginated collection of games the user wants to play.
    /// </summary>
    public record GetUserWantToPlayListResponse : PagedRetroAchievementsResponse<WantToPlayGame>
    {
    }

    /// <summary>
    /// Data about the game the user wants to play.
    /// </summary>
    public record WantToPlayGame
    {
        /// <summary>
        /// Unique identifier of the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        /// <summary>
        /// Title of the game.
        /// </summary>
        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

        /// <summary>
        /// Site-relative path to the game's icon image.
        /// </summary>
        [JsonInclude]
        public string ImageIcon { get; private set; } = string.Empty;

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
        /// Total number of points in the game.
        /// </summary>
        [JsonInclude]
        public int PointsTotal { get; private set; }

        /// <summary>
        /// Number of published achievements in the game.
        /// </summary>
        [JsonInclude]
        public int AchievementsPublished { get; private set; }
    }
}
