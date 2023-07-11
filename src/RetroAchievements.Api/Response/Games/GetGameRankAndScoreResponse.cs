using RetroAchievements.Api.Response.Games.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<GameRankAndScore, GetGameRankAndScoreResponse>))]
    public record GetGameRankAndScoreResponse : CollectionRetroAchievementsResponse<GameRankAndScore>
    {
    }
}
