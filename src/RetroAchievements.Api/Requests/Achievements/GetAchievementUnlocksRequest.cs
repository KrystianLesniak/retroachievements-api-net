using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Achievements;

namespace RetroAchievements.Api.Requests.Achievements
{
    public record GetAchievementUnlocksRequest : IRetroAchievementsRequest<GetAchievementUnlocksResponse>
    {
        public string RequestEndpoint => "API_GetAchievementUnlocks";

        public GetAchievementUnlocksRequest(int achievementId, int offset = 0, int count = 50)
        {
            ArgumentExceptionGuard.ThrowIfGreaterThan(count, nameof(count), 500);

            AchievementId = achievementId;
            Offset = offset;
            Count = count;
        }

        [ApiInputKey("a")]
        public int AchievementId { get; init; }

        [ApiInputKey("o")]
        public int Offset { get; init; }

        [ApiInputKey("c")]
        public int Count { get; init; }
    }
}
