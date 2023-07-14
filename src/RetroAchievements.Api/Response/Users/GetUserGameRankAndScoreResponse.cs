using RetroAchievements.Api.Response.Users.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Collection of user High Score data for a game.
    /// </summary>
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<GameRankAndScore, GetUserGameRankAndScoreResponse>))]
    public record GetUserGameRankAndScoreResponse : CollectionRetroAchievementsResponse<GameRankAndScore>
    {
    }
}
