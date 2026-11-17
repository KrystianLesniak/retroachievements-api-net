using RetroAchievements.Api.Response;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Paginated collection of users following the authenticated user.
    /// </summary>
    public record GetUsersFollowingMeResponse : PagedRetroAchievementsResponse<FollowingUser>
    {
    }

    /// <summary>
    /// Data about the user following the authenticated user.
    /// </summary>
    public record FollowingUser
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
        /// Hardcore points of the user.
        /// </summary>
        [JsonInclude]
        public int Points { get; private set; }

        /// <summary>
        /// Softcore points of the user.
        /// </summary>
        [JsonInclude]
        public int PointsSoftcore { get; private set; }

        /// <summary>
        /// Is the authenticated user following the user back.
        /// </summary>
        [JsonInclude]
        public bool AmIFollowing { get; private set; }
    }
}
