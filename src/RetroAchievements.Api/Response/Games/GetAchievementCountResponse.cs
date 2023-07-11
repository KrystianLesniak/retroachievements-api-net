using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    public record GetAchievementCountResponse : RetroAchievementsResponse
    {
        [JsonInclude]
        [JsonPropertyName("GameID")]
        public int GameId { get; private set; }

        [JsonInclude]
        [JsonPropertyName("AchievementsIDs")]
        public IEnumerable<int> AchievementsIds { get; private set; } = new List<int>();
    }
}
