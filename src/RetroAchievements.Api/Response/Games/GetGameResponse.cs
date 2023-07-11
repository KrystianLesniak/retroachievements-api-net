using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    public record GetGameResponse : RetroAchievementsResponse
    {
        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonPropertyName("ConsoleID")]
        public int ConsoleId { get; private set; }

        [JsonInclude]
        public string ConsoleName { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonPropertyName("ForumTopicID")]
        public int ForumTopicId { get; private set; }

        [JsonInclude]
        public string GameIcon { get; private set; } = string.Empty;

        [JsonInclude]
        public string ImageIcon { get; private set; } = string.Empty;

        [JsonInclude]
        public string ImageTitle { get; private set; } = string.Empty;

        [JsonInclude]
        public string ImageIngame { get; private set; } = string.Empty;

        [JsonInclude]
        public string ImageBoxArt { get; private set; } = string.Empty;

        [JsonInclude]
        public string Publisher { get; private set; } = string.Empty;

        [JsonInclude]
        public string Developer { get; private set; } = string.Empty;

        [JsonInclude]
        public string Genre { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime Released { get; private set; }
    }
}
