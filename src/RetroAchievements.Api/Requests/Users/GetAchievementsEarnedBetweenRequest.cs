using RetroAchievements.Api.Request;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetAchievementsEarnedBetweenRequest : IRequest
    {
        public GetAchievementsEarnedBetweenRequest(string gameId)
        {
            ArgumentNullException.ThrowIfNull(gameId);

            GameId = gameId;
        }

        public string GameId { get; init; }
    }
}
