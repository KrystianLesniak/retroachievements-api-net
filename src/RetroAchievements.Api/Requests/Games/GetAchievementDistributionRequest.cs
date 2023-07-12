
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Games;

namespace RetroAchievements.Api.Requests.Games
{
    /// <summary>
    /// TODO:
    /// </summary>
    public record GetAchievementDistributionRequest : IRetroAchievementsRequest<GetAchievementDistributionResponse>
    {
        public string RequestEndpoint => "API_GetAchievementDistribution";

        public GetAchievementDistributionRequest(int gameId, bool hardcoreOnly = false, bool unofficialAchievements = false)
        {
            ArgumentNullException.ThrowIfNull(gameId);

            GameId = gameId;
            Hardcore = hardcoreOnly ? 1 : 0;
            Flags = unofficialAchievements ? 5 : 3;
        }

        [ApiInputKey("i")]
        public int GameId { get; init; }

        [ApiInputKey("h")]
        public int Hardcore { get; init; }

        [ApiInputKey("f")]
        public int Flags { get; init; }
    }
}
