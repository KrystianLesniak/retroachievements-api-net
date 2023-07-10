using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users.Records
{
    public record GameRankAndScore
    {
        [JsonInclude]
        public string User { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int TotalScore { get; private set; }

        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime LastAward { get; private set; }

        [JsonInclude]
        public int? UserRank { get; private set; }

    }
}
