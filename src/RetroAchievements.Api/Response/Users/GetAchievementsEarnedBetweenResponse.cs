using System.Text.Json.Serialization;
using RetroAchievements.Api.Response.Users.Records;

namespace RetroAchievements.Api.Response.Users
{
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<UserAchievement, GetAchievementsEarnedBetweenResponse>))]
    public record GetAchievementsEarnedBetweenResponse : CollectionRetroAchievementsResponse<UserAchievement>
    {
    }
}
