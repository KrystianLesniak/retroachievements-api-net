using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games
{
    /// <summary>
    /// Information about the average time to unlock achievements in the game.
    /// </summary>
    public record GetGameProgressionResponse : RetroAchievementsResponse
    {
        /// <summary>
        /// Unique identifier of the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        /// <summary>
        /// Title of the game.
        /// </summary>
        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

        /// <summary>
        /// Unique identifier of the console.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ConsoleID")]
        public int ConsoleId { get; private set; }

        /// <summary>
        /// Name of the console.
        /// </summary>
        [JsonInclude]
        public string ConsoleName { get; private set; } = string.Empty;

        /// <summary>
        /// Site-relative path to the game's icon image.
        /// </summary>
        [JsonInclude]
        public string ImageIcon { get; private set; } = string.Empty;

        /// <summary>
        /// Number of distinct players who have earned an achievement in the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumDistinctPlayers")]
        public int PlayersCount { get; private set; }

        /// <summary>
        /// Number of players used to calculate the median time to beat.
        /// </summary>
        [JsonInclude]
        public int TimesUsedInBeatMedian { get; private set; }

        /// <summary>
        /// Number of players used to calculate the median time to beat in hardcore.
        /// </summary>
        [JsonInclude]
        public int TimesUsedInHardcoreBeatMedian { get; private set; }

        /// <summary>
        /// Median time (in seconds) to beat the game.
        /// </summary>
        [JsonInclude]
        public int? MedianTimeToBeat { get; private set; }

        /// <summary>
        /// Median time (in seconds) to beat the game in hardcore.
        /// </summary>
        [JsonInclude]
        public int? MedianTimeToBeatHardcore { get; private set; }

        /// <summary>
        /// Number of players used to calculate the median time to complete.
        /// </summary>
        [JsonInclude]
        public int TimesUsedInCompletionMedian { get; private set; }

        /// <summary>
        /// Number of players used to calculate the median time to master.
        /// </summary>
        [JsonInclude]
        public int TimesUsedInMasteryMedian { get; private set; }

        /// <summary>
        /// Median time (in seconds) to complete the game.
        /// </summary>
        [JsonInclude]
        public int? MedianTimeToComplete { get; private set; }

        /// <summary>
        /// Median time (in seconds) to master the game.
        /// </summary>
        [JsonInclude]
        public int? MedianTimeToMaster { get; private set; }

        /// <summary>
        /// Number of achievements in the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumAchievements")]
        public int AchievementsCount { get; private set; }

        /// <summary>
        /// Collection of achievements with progression data.
        /// </summary>
        [JsonInclude]
        public IReadOnlyCollection<GameProgressionAchievement> Achievements { get; private set; } = Array.Empty<GameProgressionAchievement>();
    }

    /// <summary>
    /// Achievement progression data.
    /// </summary>
    public record GameProgressionAchievement
    {
        /// <summary>
        /// Unique identifier of the achievement.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        /// <summary>
        /// Title of the achievement.
        /// </summary>
        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

        /// <summary>
        /// Description of the achievement.
        /// </summary>
        [JsonInclude]
        public string Description { get; private set; } = string.Empty;

        /// <summary>
        /// Number of points the achievement is worth.
        /// </summary>
        [JsonInclude]
        public int Points { get; private set; }

        /// <summary>
        /// Number of "white" points the achievement is worth.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("TrueRatio")]
        public int TrueRatioPoints { get; private set; }

        /// <summary>
        /// Type of the achievement (<see langword="progression"/>, <see langword="win_condition"/>, <see langword="missable"/> or <see langword="null"/>).
        /// </summary>
        [JsonInclude]
        public string? Type { get; private set; }

        /// <summary>
        /// Unique identifier of the badge image for the achievement.
        /// </summary>
        [JsonInclude]
        public string BadgeName { get; private set; } = string.Empty;

        /// <summary>
        /// Number of times the achievement has been awarded.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumAwarded")]
        public int AwardedCount { get; private set; }

        /// <summary>
        /// Number of times the achievement has been awarded in hardcore.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumAwardedHardcore")]
        public int AwardedHardcoreCount { get; private set; }

        /// <summary>
        /// Number of players used to calculate the median time to unlock.
        /// </summary>
        [JsonInclude]
        public int TimesUsedInUnlockMedian { get; private set; }

        /// <summary>
        /// Number of players used to calculate the median time to unlock in hardcore.
        /// </summary>
        [JsonInclude]
        public int TimesUsedInHardcoreUnlockMedian { get; private set; }

        /// <summary>
        /// Median time (in seconds) to unlock the achievement.
        /// </summary>
        [JsonInclude]
        public int? MedianTimeToUnlock { get; private set; }

        /// <summary>
        /// Median time (in seconds) to unlock the achievement in hardcore.
        /// </summary>
        [JsonInclude]
        public int? MedianTimeToUnlockHardcore { get; private set; }
    }
}
