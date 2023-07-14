using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users.Records
{
    /// <summary>
    /// Game progress data for user.
    /// </summary>
    public record GameProgress
    {
        /// <summary>
        /// Unique identifier of the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("GameID")]
        public int GameId { get; private set; }

        /// <summary>
        /// Title of the game.
        /// </summary>
        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

        /// <summary>
        /// Site-relative path to the game's image icon.
        /// </summary>
        [JsonInclude]
        public string ImageIcon { get; private set; } = string.Empty;

        /// <summary>
        /// Unique identifier of the console associated to the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ConsoleID")]
        public int ConsoleId { get; private set; }

        /// <summary>
        /// Name of the console associated to the game.
        /// </summary>
        [JsonInclude]
        public string ConsoleName { get; private set; } = string.Empty;

        /// <summary>
        /// Count of core achievements associated to the game. 
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("MaxPossible")]
        public int GameAchievementsCount { get; private set; }

        /// <summary>
        /// Count of achievements earned by the user.
        /// </summary>
        [JsonInclude]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        [JsonPropertyName("NumAwarded")]

        public int AwardedAchievementsCount { get; private set; }

        /// <summary>
        /// AwardedAchievementsCount divided by GameAchievementsCount.
        /// </summary>
        [JsonInclude]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        [JsonPropertyName("PctWon")]
        public float EarnedAchievementsPercentage { get; private set; }

        /// <summary>
        /// Is data for hardcore mode.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(NumberApiToBooleanConverter))]
        public bool HardcoreMode { get; private set; }
    }
}
