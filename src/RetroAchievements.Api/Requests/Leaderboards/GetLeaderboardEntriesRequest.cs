using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Leaderboards;

namespace RetroAchievements.Api.Requests.Leaderboards
{
    /// <summary>
    /// Get the entries of a leaderboard.
    /// </summary>
    public record GetLeaderboardEntriesRequest : IRetroAchievementsRequest<GetLeaderboardEntriesResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetLeaderboardEntries";

        ///<inheritdoc cref="GetLeaderboardEntriesRequest" />
        ///<param name="leaderboardId"><inheritdoc cref="LeaderboardId" path="/summary/node()"/></param>
        ///<param name="offset"><inheritdoc cref="Offset" path="/summary/node()"/></param>
        ///<param name="count"><inheritdoc cref="Count" path="/summary/node()"/></param>
        public GetLeaderboardEntriesRequest(int leaderboardId, int offset = 0, int count = 100)
        {
            ArgumentExceptionGuard.ThrowIfGreaterThan(count, nameof(count), 500);

            LeaderboardId = leaderboardId;
            Offset = offset;
            Count = count;
        }

        /// <summary>
        /// Unique RetroAchievements identifier of the leaderboard.
        /// </summary>
        [ApiInputKey("i")]
        public int LeaderboardId { get; init; }

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
