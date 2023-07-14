
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Games;

namespace RetroAchievements.Api.Requests.Games
{
    /// <summary>
    /// Get 'Latest Masters' or 'High Scores' entries for a game.
    /// </summary>
    public record GetGameRankAndScoreRequest : IRetroAchievementsRequest<GetGameRankAndScoreResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetGameRankAndScore";

        ///<inheritdoc cref="GetGameRankAndScoreRequest" />
        ///<param name="gameId"><inheritdoc cref="GameId" path="/summary/node()"/></param>
        ///<param name="rankType"><inheritdoc cref="RankType" path="/summary/node()"/></param>
        public GetGameRankAndScoreRequest(int gameId, RankType rankType = RankType.HighScores)
        {
            ArgumentNullException.ThrowIfNull(gameId);
            ArgumentNullException.ThrowIfNull(rankType);

            GameId = gameId;
            RankType = rankType;
        }

        /// <summary>
        /// Unique identifier of the game.
        /// </summary>
        [ApiInputKey("g")]
        public int GameId { get; init; }

        /// <summary>
        /// Type of rank to seek for.
        /// </summary>
        /// <remarks>
        /// <see cref="RankType.HighScores"/>: High Scores ranks. <br />
        /// <see cref="RankType.LatestMasters"/>: Latest Masters ranks.
        /// </remarks>
        [ApiInputKey("t")]
        public RankType RankType { get; init; }
    }

    /// <summary>
    /// <see cref="RankType.HighScores"/>: High Scores ranks. <br />
    /// <see cref="RankType.LatestMasters"/>: Latest Masters ranks.
    /// </summary>
    public enum RankType
    {
        /// <summary>
        /// High Score ranks.
        /// </summary>
        HighScores = 0,
        /// <summary>
        /// Latest Masters ranks.
        /// </summary>
        LatestMasters = 1
    }
}
