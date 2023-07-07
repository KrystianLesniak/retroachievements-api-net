using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Common
{
    public record Console
    {
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        [JsonInclude]
        public string Title { get; private set; } = string.Empty;
    }
}
