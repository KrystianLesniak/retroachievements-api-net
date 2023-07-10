using RetroAchievements.Api.Response.Users.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<GameRankAndScore, GetUserGameRankAndScoreResponse>))]
    public record GetUserGameRankAndScoreResponse : CollectionRetroAchievementsResponse<GameRankAndScore>
    {
    }
}
