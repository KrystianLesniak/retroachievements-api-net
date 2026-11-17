using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Feed;
using RetroAchievements.Api.Requests.Enums;

namespace RetroAchievements.Api.Requests.Feed
{
    /// <summary>
    /// Get all recently granted game awards across the site's userbase.
    /// </summary>
    public record GetRecentGameAwardsRequest : IRetroAchievementsRequest<GetRecentGameAwardsResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetRecentGameAwards";

        ///<inheritdoc cref="GetRecentGameAwardsRequest" />
        ///<param name="startDate"><inheritdoc cref="StartDate" path="/summary/node()"/></param>
        ///<param name="offset"><inheritdoc cref="Offset" path="/summary/node()"/></param>
        ///<param name="count"><inheritdoc cref="Count" path="/summary/node()"/></param>
        ///<param name="awardKinds"><inheritdoc cref="AwardKinds" path="/summary/node()"/></param>
        public GetRecentGameAwardsRequest(DateTime? startDate = null, int offset = 0, int count = 25, IEnumerable<AwardKind>? awardKinds = null)
        {
            ArgumentExceptionGuard.ThrowIfGreaterThan(count, nameof(count), 100);

            StartDate = startDate;
            Offset = offset;
            Count = count;
            AwardKinds = awardKinds?.Select(AwardKindToApiValue).ToArray();
        }

        /// <summary>
        /// Date to start fetching awards from (default: today).
        /// </summary>
        [ApiInputKey("d", CustomOption.DateTimeToShortDate)]
        public DateTime? StartDate { get; init; }

        /// <summary>
        /// Number of entries to skip (default: <see langword="0"/>)
        /// </summary>
        [ApiInputKey("o")]
        public int Offset { get; init; }

        /// <summary>
        /// Number of entries to return (default: <see langword="25"/>, max: <see langword="100"/>)
        /// </summary>
        [ApiInputKey("c")]
        public int Count { get; init; }

        /// <summary>
        /// Kinds of awards to return (default: all kinds).
        /// </summary>
        [ApiInputKey("k")]
        public IEnumerable<string>? AwardKinds { get; init; }

        private static string AwardKindToApiValue(AwardKind awardKind) => awardKind switch
        {
            AwardKind.BeatenSoftcore => "beaten-softcore",
            AwardKind.BeatenHardcore => "beaten-hardcore",
            AwardKind.Completed => "completed",
            AwardKind.Mastered => "mastered",
            _ => throw new ArgumentOutOfRangeException(nameof(awardKind)),
        };
    }
}
