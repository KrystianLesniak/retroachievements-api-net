using RetroAchievements.Api.Response.Users.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Collection of achievements recently earned by user.
    /// </summary>
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<UserAchievement, GetUserRecentAchievementsResponse>))]
    public record GetUserRecentAchievementsResponse : CollectionRetroAchievementsResponse<UserAchievement>
    {
    }
}
