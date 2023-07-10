using RetroAchievements.Api.Response.Users.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    [JsonConverter(typeof(DictionaryRetroAchievementsResponseConverter<int, UserProgress, GetUserProgressResponse>))]

    public record GetUserProgressResponse : DictionaryRetroAchievementsResponse<int, UserProgress>
    {
    }
}
