using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    public record GetUserRankAndPointsResponse : RetroAchievementsResponse
    {
        [JsonInclude]
        [JsonPropertyName("Score")]
        public int HardcorePoints { get; private set; }

        [JsonInclude]
        public int SoftcorePoints { get; private set; }

        [JsonInclude]
        public int Rank { get; private set; }

        [JsonInclude]
        public int TotalRanked { get; private set; }

    }
}
