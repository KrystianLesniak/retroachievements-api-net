using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games.Records
{
    public record GameAchievement
    {
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

        [JsonInclude]
        public string Description { get; private set; } = string.Empty;

        [JsonInclude]
        public int Points { get; private set; }

        [JsonInclude]
        public int TrueRatio { get; private set; }

        [JsonInclude]
        public string BadgeName { get; private set; } = string.Empty;

        [JsonInclude]
        public int NumAwarded { get; private set; }

        [JsonInclude]
        public int NumAwardedHardcore { get; private set; }

        [JsonInclude]
        public int DisplayOrder { get; private set; }

        [JsonInclude]
        public string Author { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime DateCreated { get; private set; }

        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime DateModified { get; private set; }

    }
}
