using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games.Records
{
    public record GameRankAndScore
    {
        [JsonInclude]
        public string User { get; private set; } = string.Empty;

        [JsonInclude]
        public int NumAchievements { get; private set; }

        [JsonInclude]
        public int TotalScore { get; private set; }

        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime LastAward { get; private set; }

    }
}
