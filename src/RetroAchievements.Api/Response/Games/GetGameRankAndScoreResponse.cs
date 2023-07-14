using RetroAchievements.Api.Response.Games.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games
{
    /// <summary>
    /// Collection of Latest Masters or High Scores for specific game.
    /// </summary>
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<GameRankAndScore, GetGameRankAndScoreResponse>))]
    public record GetGameRankAndScoreResponse : CollectionRetroAchievementsResponse<GameRankAndScore>
    {
    }
}
