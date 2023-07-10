using System.Text.Json.Serialization;
using RetroAchievements.Api.Response.Users.Records;

namespace RetroAchievements.Api.Response.Users
{
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<UserAchievement, GetUserRecentAchievementsResponse>))]
    public record GetUserRecentAchievementsResponse : CollectionRetroAchievementsResponse<UserAchievement>
    {
    }
}
