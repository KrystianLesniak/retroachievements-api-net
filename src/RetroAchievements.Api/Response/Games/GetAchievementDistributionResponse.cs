using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games
{
    [JsonConverter(typeof(DictionaryRetroAchievementsResponseConverter<int, int, GetAchievementDistributionResponse>))]

    public record GetAchievementDistributionResponse : DictionaryRetroAchievementsResponse<int, int>
    {

    }
}
