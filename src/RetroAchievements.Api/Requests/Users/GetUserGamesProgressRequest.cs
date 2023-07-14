using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;


namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Gets user's progress for a specified games collection.
    /// </summary>
    public record GetUserGamesProgressRequest : IRetroAchievementsRequest<GetUserGamesProgressResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetUserProgress";

        ///<inheritdoc cref="GetUserGamesProgressRequest" />
        ///<param name="username"><inheritdoc cref="Username" path="/summary/node()"/></param>
        ///<param name="gameIds"><inheritdoc cref="GameIds" path="/summary/node()"/></param>
        public GetUserGamesProgressRequest(string username, IEnumerable<int> gameIds)
        {
            ArgumentNullException.ThrowIfNull(username, nameof(username));
            ArgumentNullException.ThrowIfNull(gameIds, nameof(gameIds));
            ArgumentExceptionGuard.ThrowIfEmpty(gameIds, nameof(gameIds));

            Username = username;
            GameIds = gameIds;
        }
        /// <summary>
        /// Username of user.
        /// </summary>
        [ApiInputKey("u")]
        public string Username { get; init; }

        /// <summary>
        /// Collection of game identifiers progress should be get from.
        /// </summary>
        [ApiInputKey("i")]
        public IEnumerable<int> GameIds { get; init; }
    }
}
