using RetroAchievements.Api.Response.Users.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Collection of an achievements that was earned on specified date.
    /// </summary>
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<UserAchievement, GetAchievementsEarnedOnDayResponse>))]
    public record GetAchievementsEarnedOnDayResponse : CollectionRetroAchievementsResponse<UserAchievement>
    {
    }
}
