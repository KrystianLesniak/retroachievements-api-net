using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get collection of recently played games by an user.
    /// </summary>
    public record GetUserRecentlyPlayedGamesRequest : IRetroAchievementsRequest<GetUserRecentlyPlayedGamesResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetUserRecentlyPlayedGames";

        ///<inheritdoc cref="GetUserRecentlyPlayedGamesRequest" />
        ///<param name="username"><inheritdoc cref="Username" path="/summary/node()"/></param>
        ///<param name="offset"><inheritdoc cref="Offset" path="/summary/node()"/></param>
        ///<param name="count"><inheritdoc cref="Count" path="/summary/node()"/></param>
        public GetUserRecentlyPlayedGamesRequest(string username, int offset = 0, int count = 10)
        {
            ArgumentExceptionGuard.ThrowIfNullOrWhitespace(username, nameof(username));
            ArgumentExceptionGuard.ThrowIfGreaterThan(count, nameof(count), 50);

            Username = username;
            Offset = offset;
            Count = count;
        }

        /// <summary>
        /// Username of an user to seek recently played games for.
        /// </summary>
        [ApiInputKey("u")]
        public string Username { get; init; }

        /// <summary>
        /// Number of entries to skip (default: <see langword="0"/>)
        /// </summary>
        [ApiInputKey("o")]
        public int Offset { get; init; }

        /// <summary>
        /// Number of entries to return (default: <see langword="10"/>, max: <see langword="50"/>)
        /// </summary>
        [ApiInputKey("c")]
        public int Count { get; init; }
    }
}
