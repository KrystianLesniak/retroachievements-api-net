using RetroAchievements.Api.Response.Users.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Collection of an achievements that was earned between specified timestamp.
    /// </summary>
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<UserAchievement, GetAchievementsEarnedBetweenResponse>))]
    public record GetAchievementsEarnedBetweenResponse : CollectionRetroAchievementsResponse<UserAchievement>
    {
    }
}
