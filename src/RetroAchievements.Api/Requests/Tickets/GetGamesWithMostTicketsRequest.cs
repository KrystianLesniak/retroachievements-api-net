
using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Tickets;

namespace RetroAchievements.Api.Requests.Tickets
{
    /// <summary>
    /// Get games with the most open tickets.
    /// </summary>
    public record GetGamesWithMostTicketsRequest : IRetroAchievementsRequest<GetGamesWithMostTicketsResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetTicketData";

        ///<inheritdoc cref="GetGamesWithMostTicketsRequest" />
        ///<param name="offset"><inheritdoc cref="Offset" path="/summary/node()"/></param>
        ///<param name="count"><inheritdoc cref="Count" path="/summary/node()"/></param>
        public GetGamesWithMostTicketsRequest(int offset = 0, int count = 10)
        {
            ArgumentExceptionGuard.ThrowIfGreaterThan(count, nameof(count), 100);

            Offset = offset;
            Count = count;
        }

        /// <summary>
        /// Number of entries to skip (default: <see langword="0"/>).
        /// </summary>
        [ApiInputKey("o")]
        public int Offset { get; init; }

        /// <summary>
        /// Number of entries to return (default: <see langword="10"/>, max: <see langword="100"/>).
        /// </summary>
        [ApiInputKey("c")]
        public int Count { get; init; }

        /// <summary>
        /// Internal API Flag
        /// </summary>
        [ApiInputKey("f")]
        public int ConstApiFlag { get; init; } = 1;
    }
}
