using RetroAchievements.Api.Response.Achievements.Records;
using RetroAchievements.Api.Response.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Achievements
{
    public record GetAchievementUnlocksResponse : RetroAchievementsResponse
    {
        [JsonInclude]
        public Achievement Achievement { get; private set; } = new();

        [JsonInclude]
        public Response.Records.Console Console { get; private set; } = new();

        [JsonInclude]
        public AchievementGame Game { get; private set; } = new();

        [JsonInclude]
        public int UnlocksCount { get; private set; }

        [JsonInclude]
        public int TotalPlayers { get; private set; }

        [JsonInclude]
        public IEnumerable<Unlock> Unlocks { get; private set; } = new List<Unlock>();

    }
}
