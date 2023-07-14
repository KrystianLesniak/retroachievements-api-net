using RetroAchievements.Api.Response.Users.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Collection of game progress data for user.
    /// </summary>
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<GameProgress, GetUserAllGamesProgressResponse>))]
    public record GetUserAllGamesProgressResponse : CollectionRetroAchievementsResponse<GameProgress>
    {
    }
}
