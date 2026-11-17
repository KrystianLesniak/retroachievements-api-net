using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Comments
{
    /// <summary>
    /// Paginated collection of comments.
    /// </summary>
    public record GetCommentsResponse : PagedRetroAchievementsResponse<Comment>
    {
    }

    /// <summary>
    /// Data about the comment.
    /// </summary>
    public record Comment
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
        /// Date the comment was submitted.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        [JsonPropertyName("Submitted")]
        public DateTime SubmittedDate { get; private set; }

        /// <summary>
        /// Text of the comment.
        /// </summary>
        [JsonInclude]
        public string CommentText { get; private set; } = string.Empty;
    }
}
