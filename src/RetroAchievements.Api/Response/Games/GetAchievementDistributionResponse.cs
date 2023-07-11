using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    [JsonConverter(typeof(DictionaryRetroAchievementsResponseConverter<string, int, GetAchievementDistributionResponse>))]

    public record GetAchievementDistributionResponse : DictionaryRetroAchievementsResponse<string, int>
    {

    }
}
