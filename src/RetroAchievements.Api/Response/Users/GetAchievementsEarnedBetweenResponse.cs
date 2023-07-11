using RetroAchievements.Api.Response.Users.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<UserAchievement, GetAchievementsEarnedBetweenResponse>))]
    public record GetAchievementsEarnedBetweenResponse : CollectionRetroAchievementsResponse<UserAchievement>
    {
    }
}
