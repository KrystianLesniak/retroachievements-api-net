using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users.Records
{
    public record UserProgress
    {
        /// <summary>
        /// Count of core achievements for the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumPossibleAchievements")]
        public int PossibleAchievements { get; private set; }

        /// <summary>
        /// Maximum number of points that can be earned from the game.
        /// </summary>
        [JsonInclude]
        public int PossibleScore { get; private set; }

        /// <summary>
        /// Count of achievements earned by the user in softcore.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumAchieved")]
        public int EarnedAchievements { get; private set; }

        /// <summary>
        /// Count of points earned by the user in softcore.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ScoreAchieved")]
        public int EarnedScore { get; private set; }

        /// <summary>
        /// Count of achievements earned by the user in hardcore.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumAchievedHardcore")]
        public int EarnedAchievementsHardcore { get; private set; }

        /// <summary>
        /// Count of points earned by the user in hardcore.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ScoreAchievedHardcore")]
        public int EarnedScoreHardcore { get; private set; }

    }
}
