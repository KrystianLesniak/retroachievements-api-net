using RetroAchievements.Api.Response.Users.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<UserAchievement, GetUserRecentAchievementsResponse>))]
    public record GetUserRecentAchievementsResponse : CollectionRetroAchievementsResponse<UserAchievement>
    {
    }
}
