using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Leaderboards;

namespace RetroAchievements.Api.Requests.Leaderboards
{
    /// <summary>
    /// Get the leaderboards of a game.
    /// </summary>
    public record GetGameLeaderboardsRequest : IRetroAchievementsRequest<GetGameLeaderboardsResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetGameLeaderboards";

        ///<inheritdoc cref="GetGameLeaderboardsRequest" />
        ///<param name="gameId"><inheritdoc cref="GameId" path="/summary/node()"/></param>
        ///<param name="offset"><inheritdoc cref="Offset" path="/summary/node()"/></param>
        ///<param name="count"><inheritdoc cref="Count" path="/summary/node()"/></param>
        public GetGameLeaderboardsRequest(int gameId, int offset = 0, int count = 100)
        {
            ArgumentExceptionGuard.ThrowIfGreaterThan(count, nameof(count), 500);

            GameId = gameId;
            Offset = offset;
            Count = count;
        }

        /// <summary>
        /// Unique RetroAchievements identifier of the game.
        /// </summary>
        [ApiInputKey("i")]
        public int GameId { get; init; }

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
