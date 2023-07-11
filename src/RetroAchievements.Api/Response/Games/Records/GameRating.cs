using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games.Records
{
    public class GameRating
    {
        [JsonInclude]
        [JsonPropertyName("Game")]
        public double AverageGameRating { get; private set; }

        [JsonInclude]
        [JsonPropertyName("Achievements")]
        public double AverageAchievementsRating { get; private set; }

        [JsonInclude]
        [JsonPropertyName("GameNumVotes")]
        public int GameVotesCount { get; private set; }

        [JsonInclude]
        [JsonPropertyName("AchievementsNumVotes")]
        public int AchievementVotesCount { get; private set; }
    }
}