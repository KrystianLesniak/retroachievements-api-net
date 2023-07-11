using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games
{
    public record GetAchievementCountResponse : RetroAchievementsResponse
    {
        [JsonInclude]
        [JsonPropertyName("GameID")]
        public int GameId { get; private set; }

        [JsonInclude]
        [JsonPropertyName("AchievementIDs")]
        public IEnumerable<int> AchievementIds { get; private set; } = new List<int>();
    }
}
