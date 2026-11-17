using RetroAchievements.Api.Internal.Json.Converters;
using RetroAchievements.Api.Response;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Feed
{
    /// <summary>
    /// Paginated collection of recently granted game awards.
    /// </summary>
    public record GetRecentGameAwardsResponse : PagedRetroAchievementsResponse<RecentGameAward>
    {
    }

    /// <summary>
    /// Data about recently granted game award.
    /// </summary>
    public record RecentGameAward
    {
        /// <summary>
        /// Username of the user.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("User")]
        public string Username { get; private set; } = string.Empty;

        /// <summary>
        /// Unique, stable identifier (ULID) of the user.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ULID")]
        public string? Ulid { get; private set; }

        /// <summary>
        /// Kind of the award (<see langword="beaten-softcore"/>, <see langword="beaten-hardcore"/>, <see langword="completed"/> or <see langword="mastered"/>).
        /// </summary>
        [JsonInclude]
        public string AwardKind { get; private set; } = string.Empty;

        /// <summary>
        /// Date the award was granted.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime AwardDate { get; private set; }

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
    }
}
