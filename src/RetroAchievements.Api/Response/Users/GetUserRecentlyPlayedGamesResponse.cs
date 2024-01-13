using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Collection of a target user recently played games
    /// </summary>
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<UserRecentlyPlayedGame, GetUserRecentlyPlayedGamesResponse>))]
    public record GetUserRecentlyPlayedGamesResponse : CollectionRetroAchievementsResponse<UserRecentlyPlayedGame>
    {
    }

    /// <summary>
    /// User recently played game.
    /// </summary>
    public record UserRecentlyPlayedGame
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
        /// Count of core achievements for the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumPossibleAchievements")]
        public int PossibleAchievementsCount { get; private set; }

        /// <summary>
        /// Maximum number of points that can be earned from the game.
        /// </summary>
        [JsonInclude]
        public int PossibleScore { get; private set; }

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
        /// Site-relative path to the game's icon image.
        /// </summary>
        [JsonInclude]
        public string ImageIcon { get; private set; } = string.Empty;
        /// <summary>
        /// Site-relative path to the game's title image.
        /// </summary>
        [JsonInclude]
        public string ImageTitle { get; private set; } = string.Empty;

        /// <summary>
        /// Site-relative path to the game's in-game image.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ImageIngame")]
        public string ImageInGame { get; private set; } = string.Empty;

        /// <summary>
        /// Site-relative path to the game's box art image.
        /// </summary>
        [JsonInclude]
        public string ImageBoxArt { get; private set; } = string.Empty;

        /// <summary>
        /// Date when the user last played the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("LastPlayed")]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime LastPlayedDate { get; private set; }

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
