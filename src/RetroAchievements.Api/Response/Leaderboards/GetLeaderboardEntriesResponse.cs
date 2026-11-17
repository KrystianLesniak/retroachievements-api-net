using RetroAchievements.Api.Internal.Json.Converters;
using RetroAchievements.Api.Response;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Leaderboards
{
    /// <summary>
    /// Paginated collection of the leaderboard entries.
    /// </summary>
    public record GetLeaderboardEntriesResponse : PagedRetroAchievementsResponse<LeaderboardEntry>
    {
    }

    /// <summary>
    /// Data about the leaderboard entry.
    /// </summary>
    public record LeaderboardEntry
    {
        /// <summary>
        /// Rank of the entry.
        /// </summary>
        [JsonInclude]
        public int Rank { get; private set; }

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
        /// Date the entry was submitted.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime DateSubmitted { get; private set; }
    }
}
