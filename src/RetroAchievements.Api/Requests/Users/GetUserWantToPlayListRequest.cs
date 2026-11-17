using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get the user's "Want to Play Games" list.
    /// </summary>
    public record GetUserWantToPlayListRequest : IRetroAchievementsRequest<GetUserWantToPlayListResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetUserWantToPlayList";

        ///<inheritdoc cref="GetUserWantToPlayListRequest" />
        ///<param name="username"><inheritdoc cref="Username" path="/summary/node()"/></param>
        ///<param name="offset"><inheritdoc cref="Offset" path="/summary/node()"/></param>
        ///<param name="count"><inheritdoc cref="Count" path="/summary/node()"/></param>
        public GetUserWantToPlayListRequest(string username, int offset = 0, int count = 100)
        {
            ArgumentExceptionGuard.ThrowIfNullOrWhitespace(username, nameof(username));
            ArgumentExceptionGuard.ThrowIfGreaterThan(count, nameof(count), 500);

            Username = username;
            Offset = offset;
            Count = count;
        }

        /// <summary>
        /// Username of an user to seek data for.
        /// </summary>
        [ApiInputKey("u")]
        public string Username { get; init; }

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
