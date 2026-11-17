using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Comments;
using RetroAchievements.Api.Requests.Enums;

namespace RetroAchievements.Api.Requests.Comments
{
    /// <summary>
    /// Get comments of a specified kind: game, achievement, or user wall.
    /// </summary>
    public record GetCommentsRequest : IRetroAchievementsRequest<GetCommentsResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetComments";

        ///<inheritdoc cref="GetCommentsRequest" />
        ///<param name="identifier"><inheritdoc cref="Identifier" path="/summary/node()"/></param>
        ///<param name="kind"><inheritdoc cref="Kind" path="/summary/node()"/></param>
        ///<param name="offset"><inheritdoc cref="Offset" path="/summary/node()"/></param>
        ///<param name="count"><inheritdoc cref="Count" path="/summary/node()"/></param>
        public GetCommentsRequest(int identifier, CommentKind kind, int offset = 0, int count = 100)
        {
            ArgumentExceptionGuard.ThrowIfGreaterThan(count, nameof(count), 500);

            Identifier = identifier.ToString();
            Kind = kind;
            Offset = offset;
            Count = count;
        }

        ///<summary>
        /// Get comments posted on the user's wall.
        ///</summary>
        ///<param name="username">Username of an user to seek wall comments for.</param>
        ///<param name="offset"><inheritdoc cref="Offset" path="/summary/node()"/></param>
        ///<param name="count"><inheritdoc cref="Count" path="/summary/node()"/></param>
        public GetCommentsRequest(string username, int offset = 0, int count = 100)
        {
            ArgumentExceptionGuard.ThrowIfNullOrWhitespace(username, nameof(username));
            ArgumentExceptionGuard.ThrowIfGreaterThan(count, nameof(count), 500);

            Identifier = username;
            Kind = CommentKind.User;
            Offset = offset;
            Count = count;
        }

        /// <summary>
        /// Identifier of the entity: game id, achievement id or username.
        /// </summary>
        [ApiInputKey("i")]
        public string Identifier { get; init; }

        /// <summary>
        /// Kind of the entity the comments are attached to.
        /// </summary>
        [ApiInputKey("t")]
        public CommentKind Kind { get; init; }

        /// <summary>
        /// Number of entries to skip (default: <see langword="0"/>)
        /// </summary>
        [ApiInputKey("o")]
        public int Offset { get; init; }

        /// <summary>
        /// Number of entries to return (default: <see langword="100"/>, max: <see langword="500"/>)
        /// </summary>
        [ApiInputKey("c")]
        public int Count { get; init; }
    }
}
