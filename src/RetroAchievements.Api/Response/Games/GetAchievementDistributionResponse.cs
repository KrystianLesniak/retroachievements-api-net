using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games
{
    /// <summary>
    ///  Dictionary where <see langword="Key"/> is players count who have earned specified <see langword="Value"/> count of achievements.
    /// </summary>
    [JsonConverter(typeof(DictionaryRetroAchievementsResponseConverter<int, int, GetAchievementDistributionResponse>))]
    public record GetAchievementDistributionResponse : DictionaryRetroAchievementsResponse<int, int>
    {

    }
}
