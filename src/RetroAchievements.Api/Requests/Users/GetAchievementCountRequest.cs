using RetroAchievements.Api.Request;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetAchievementCountRequest : IRequest
    {
        public string RequestEndpoint => "API_GetAchievementCount";

        public GetAchievementCountRequest(int gameId)
        {
            ArgumentNullException.ThrowIfNull(gameId);

            GameId = gameId;
        }

        [ApiInputKey("i")]
        public int GameId { get; init; }
    }
}
