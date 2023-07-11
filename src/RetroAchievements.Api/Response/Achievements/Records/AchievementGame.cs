using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Achievements.Records
{
    public record AchievementGame
    {
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

    }
}
