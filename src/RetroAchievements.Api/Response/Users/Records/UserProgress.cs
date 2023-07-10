using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users.Records
{
    public record UserProgress
    {
        [JsonInclude]
        [JsonPropertyName("NumPossibleAchievements")]
        public int PossibleAchievements { get; private set; }

        [JsonInclude]
        public int PossibleScore { get; private set; }

        [JsonInclude]
        [JsonPropertyName("NumAchieved")]
        public int EarnedAchievements { get; private set; }

        [JsonInclude]
        [JsonPropertyName("ScoreAchieved")]
        public int EarnedScore { get; private set; }

        [JsonInclude]
        [JsonPropertyName("NumAchievedHardcore")]
        public int EarnedAchievementsHardcore { get; private set; }

        [JsonInclude]
        [JsonPropertyName("ScoreAchievedHardcore")]
        public int EarnedScoreHardcore { get; private set; }

    }
}
