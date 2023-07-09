using RetroAchievements.Api.Response.Common;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    [JsonConverter(typeof(BaseCollectionRetroAchievementsResponseConverter<UserAchievement, GetAchievementsEarnedBetweenResponse>))]
    public record GetAchievementsEarnedBetweenResponse :  BaseCollectionRetroAchievementsResponse<UserAchievement>
    {
    }
}
