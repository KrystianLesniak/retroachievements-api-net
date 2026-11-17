using RetroAchievements.Api.Internal.Json.Converters;
using RetroAchievements.Api.Response;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Paginated collection of the user's games completion progress.
    /// </summary>
    public record GetUserCompletionProgressResponse : PagedRetroAchievementsResponse<UserCompletionProgressEntry>
    {
    }

    /// <summary>
    /// Completion progress of the user for the game.
    /// </summary>
    public record UserCompletionProgressEntry
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
        /// Number of achievements in the game.
        /// </summary>
        [JsonInclude]
        public int MaxPossible { get; private set; }

        /// <summary>
        /// Number of achievements earned by the user.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumAwarded")]
        public int AwardedCount { get; private set; }

        /// <summary>
        /// Number of achievements earned by the user in hardcore.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumAwardedHardcore")]
        public int AwardedHardcoreCount { get; private set; }

        /// <summary>
        /// Date of the most recent achievement earned by the user.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime? MostRecentAwardedDate { get; private set; }

        /// <summary>
        /// Kind of the award (<see langword="beaten-softcore"/>, <see langword="beaten-hardcore"/>, <see langword="completed"/> or <see langword="mastered"/>).
        /// </summary>
        [JsonInclude]
        public string? HighestAwardKind { get; private set; }

        /// <summary>
        /// Date the highest award was earned.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime? HighestAwardDate { get; private set; }
    }
}
