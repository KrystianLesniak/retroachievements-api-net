using RetroAchievements.Api.Response.Games.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games
{
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<GameRankAndScore, GetGameRankAndScoreResponse>))]
    public record GetGameRankAndScoreResponse : CollectionRetroAchievementsResponse<GameRankAndScore>
    {
    }
}
