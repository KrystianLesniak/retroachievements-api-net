using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Leaderboards;

namespace RetroAchievements.Api.Requests.Leaderboards
{
    /// <summary>
    /// Get the user's entries of the game leaderboards.
    /// </summary>
    public record GetUserGameLeaderboardsRequest : IRetroAchievementsRequest<GetUserGameLeaderboardsResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetUserGameLeaderboards";

        ///<inheritdoc cref="GetUserGameLeaderboardsRequest" />
        ///<param name="gameId"><inheritdoc cref="GameId" path="/summary/node()"/></param>
        ///<param name="username"><inheritdoc cref="Username" path="/summary/node()"/></param>
        ///<param name="offset"><inheritdoc cref="Offset" path="/summary/node()"/></param>
        ///<param name="count"><inheritdoc cref="Count" path="/summary/node()"/></param>
        public GetUserGameLeaderboardsRequest(int gameId, string username, int offset = 0, int count = 200)
        {
            ArgumentExceptionGuard.ThrowIfNullOrWhitespace(username, nameof(username));
            ArgumentExceptionGuard.ThrowIfGreaterThan(count, nameof(count), 500);

            GameId = gameId;
            Username = username;
            Offset = offset;
            Count = count;
        }

        /// <summary>
        /// Unique RetroAchievements identifier of the game.
        /// </summary>
        [ApiInputKey("i")]
        public int GameId { get; init; }

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
        /// Number of entries to return (default: <see langword="200"/>, max: <see langword="500"/>)
        /// </summary>
        [ApiInputKey("c")]
        public int Count { get; init; }
    }
}
