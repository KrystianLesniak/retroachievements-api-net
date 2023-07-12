using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Achievements;

namespace RetroAchievements.Api.Requests.Achievements
{
    /// <summary>
    /// Get Unlocks for specified Achievement
    /// </summary>
    public record GetAchievementUnlocksRequest : IRetroAchievementsRequest<GetAchievementUnlocksResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetAchievementUnlocks";

        ///<inheritdoc cref="GetAchievementUnlocksRequest" />
        ///<param name="achievementId"><inheritdoc cref="AchievementId" path="/summary/node()"/></param>
        ///<param name="offset"><inheritdoc cref="Offset" path="/summary/node()"/></param>
        ///<param name="count"><inheritdoc cref="Count" path="/summary/node()"/></param>
        public GetAchievementUnlocksRequest(int achievementId, int offset = 0, int count = 50)
        {
            ArgumentExceptionGuard.ThrowIfGreaterThan(count, nameof(count), 500);

            AchievementId = achievementId;
            Offset = offset;
            Count = count;
        }

        /// <summary>
        /// RetroAchievements Achievement Identifier
        /// </summary>
        [ApiInputKey("a")]
        public int AchievementId { get; init; }

        /// <summary>
        /// Number of entries to skip (default: <see langword="0"/>)
        /// </summary>
        [ApiInputKey("o")]
        public int Offset { get; init; }

        /// <summary>
        /// Number of entries to return (default: <see langword="50"/>, max: <see langword="500"/>)
        /// </summary>
        [ApiInputKey("c")]
        public int Count { get; init; }
    }
}
