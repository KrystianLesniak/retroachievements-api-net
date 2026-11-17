using RetroAchievements.Api.Internal.Json.Converters;
using RetroAchievements.Api.Response;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Leaderboards
{
    /// <summary>
    /// Paginated collection of the user's entries of the game leaderboards.
    /// </summary>
    public record GetUserGameLeaderboardsResponse : PagedRetroAchievementsResponse<UserGameLeaderboard>
    {
    }

    /// <summary>
    /// Data about the game leaderboard with the user's entry.
    /// </summary>
    public record UserGameLeaderboard
    {
        /// <summary>
        /// Unique identifier of the leaderboard.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        /// <summary>
        /// Is the leaderboard ranked ascending (lower score is better).
        /// </summary>
        [JsonInclude]
        public bool RankAsc { get; private set; }

        /// <summary>
        /// Title of the leaderboard.
        /// </summary>
        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

        /// <summary>
        /// Description of the leaderboard.
        /// </summary>
        [JsonInclude]
        public string Description { get; private set; } = string.Empty;

        /// <summary>
        /// Format of the leaderboard score.
        /// </summary>
        [JsonInclude]
        public string Format { get; private set; } = string.Empty;

        /// <summary>
        /// User's entry of the leaderboard.
        /// </summary>
        [JsonInclude]
        public UserLeaderboardEntry UserEntry { get; private set; } = new();
    }

    /// <summary>
    /// Data about the user's leaderboard entry.
    /// </summary>
    public record UserLeaderboardEntry
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
        /// Raw score of the entry.
        /// </summary>
        [JsonInclude]
        public int Score { get; private set; }

        /// <summary>
        /// Formatted score of the entry.
        /// </summary>
        [JsonInclude]
        public string FormattedScore { get; private set; } = string.Empty;

        /// <summary>
        /// Rank of the entry.
        /// </summary>
        [JsonInclude]
        public int Rank { get; private set; }

        /// <summary>
        /// Date the entry was last updated.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime DateUpdated { get; private set; }
    }
}
