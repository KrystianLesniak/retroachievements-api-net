
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Games;

namespace RetroAchievements.Api.Requests.Games
{
    public record GetGameRankAndScoreRequest : IRetroAchievementsRequest<GetGameRankAndScoreResponse>
    {
        public string RequestEndpoint => "API_GetGameRankAndScore";

        public GetGameRankAndScoreRequest(int gameId, RankType rankType = RankType.HighScores)
        {
            ArgumentNullException.ThrowIfNull(gameId);
            ArgumentNullException.ThrowIfNull(rankType);

            GameId = gameId;
            RankType = rankType;
        }

        [ApiInputKey("g")]
        public int GameId { get; init; }

        [ApiInputKey("t")]
        public RankType RankType { get; init; }
    }

    public enum RankType
    {
        HighScores = 0,
        LatestMasters = 1
    }
}
