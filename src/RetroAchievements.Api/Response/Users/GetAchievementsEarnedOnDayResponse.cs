using System.Text.Json.Serialization;
using RetroAchievements.Api.Response.Users.Records;

namespace RetroAchievements.Api.Response.Users
{
    [JsonConverter(typeof(BaseCollectionRetroAchievementsResponseConverter<UserAchievement, GetAchievementsEarnedOnDayResponse>))]
    public record GetAchievementsEarnedOnDayResponse : CollectionRetroAchievementsResponse<UserAchievement>
    {
    }
}
