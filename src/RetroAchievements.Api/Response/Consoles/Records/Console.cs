using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Consoles.Records
{
    public record Console
    {
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        [JsonInclude]
        public string Name { get; private set; } = string.Empty;
    }
}
