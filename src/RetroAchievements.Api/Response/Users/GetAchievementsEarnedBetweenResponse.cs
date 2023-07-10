using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    [JsonConverter(typeof(BaseCollectionRetroAchievementsResponseConverter<UserAchievement, GetAchievementsEarnedBetweenResponse>))]
    public record GetAchievementsEarnedBetweenResponse : CollectionRetroAchievementsResponse<UserAchievement>
    {
    }
}
