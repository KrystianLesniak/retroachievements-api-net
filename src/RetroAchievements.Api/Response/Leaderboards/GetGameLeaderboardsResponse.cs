using RetroAchievements.Api.Response;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Leaderboards
{
    /// <summary>
    /// Paginated collection of the game leaderboards.
    /// </summary>
    public record GetGameLeaderboardsResponse : PagedRetroAchievementsResponse<GameLeaderboard>
    {
    }

    /// <summary>
    /// Data about the game leaderboard.
    /// </summary>
    public record GameLeaderboard
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
        /// User who created the leaderboard.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("Author")]
        public string AuthorUsername { get; private set; } = string.Empty;

        /// <summary>
        /// Unique, stable identifier (ULID) of the user who created the leaderboard.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("AuthorULID")]
        public string? AuthorUlid { get; private set; }

        /// <summary>
        /// State of the leaderboard (<see langword="active"/>, <see langword="disabled"/> or <see langword="unpublished"/>).
        /// </summary>
        [JsonInclude]
        public string State { get; private set; } = string.Empty;

        /// <summary>
        /// Top entry of the leaderboard.
        /// </summary>
        [JsonInclude]
        public LeaderboardTopEntry? TopEntry { get; private set; }
    }

    /// <summary>
    /// Top entry of the leaderboard.
    /// </summary>
    public record LeaderboardTopEntry
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
    }
}
