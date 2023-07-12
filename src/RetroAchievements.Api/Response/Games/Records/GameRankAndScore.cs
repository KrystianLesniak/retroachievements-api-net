using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games.Records
{
    public record GameRankAndScore
    {
        [JsonInclude]
        [JsonPropertyName("User")]
        public string Username { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonPropertyName("NumAchievements")]
        public int AchievementsEarnedCount { get; private set; }

        [JsonInclude]
        public int TotalScore { get; private set; }

        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime LastAwardDate { get; private set; }

    }
}
