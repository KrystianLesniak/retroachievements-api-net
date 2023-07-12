using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Consoles.Records
{
    public record Game
    {
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonPropertyName("ConsoleID")]
        public int ConsoleId { get; private set; }

        [JsonInclude]
        public string ConsoleName { get; private set; } = string.Empty;

        [JsonInclude]
        public string ImageIcon { get; private set; } = string.Empty;

        [JsonInclude]
        public int NumAchievements { get; private set; }

        [JsonInclude]
        public int NumLeaderboards { get; private set; }

        [JsonInclude]
        public int Points { get; private set; }

        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime? DateModified { get; private set; }

        [JsonInclude]
        [JsonPropertyName("ForumTopicID")]
        public int? ForumTopicId { get; private set; }

        public IEnumerable<string> Hashes { get; private set; } = new List<string>();
    }
}
