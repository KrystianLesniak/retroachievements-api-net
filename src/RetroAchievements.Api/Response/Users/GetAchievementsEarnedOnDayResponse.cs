using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    [JsonConverter(typeof(BaseCollectionRetroAchievementsResponseConverter<UserAchievement, GetAchievementsEarnedOnDayResponse>))]
    public record GetAchievementsEarnedOnDayResponse :  CollectionRetroAchievementsResponse<UserAchievement>
    {
    }
}
