using RetroAchievements.Api.Internal.Json.Converters;
using RetroAchievements.Api.Response.Users.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    public record GetUserSummaryResponse : RetroAchievementsResponse
    {
        /// <summary>
        /// Unique identifier of the user.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("UserID")]
        public int UserId { get; private set; }

        /// <summary>
        /// Total hardcore points earned by the user.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("TotalPoints")]
        public int TotalHardcorePoints { get; private set; }

        /// <summary>
        /// Total softcore points earned by the user.
        /// </summary>
        [JsonInclude]
        public int TotalSoftcorePoints { get; private set; }

        /// <summary>
        /// Total "white" points earned by the user.
        /// </summary>
        [JsonInclude]
        public int TotalTruePoints { get; private set; }

        /// <summary>
        /// Unique identifier of user's account type
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("Permissions")]
        public int PermissionsId { get; private set; }

        /// <summary>
        /// Date when the user joined the site
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime MemberSince { get; private set; }

        /// <summary>
        /// User site rank
        /// </summary>
        [JsonInclude]
        public int? Rank { get; private set; }

        /// <summary>
        /// Is user untracked.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(NumberApiToBooleanConverter))]
        [JsonPropertyName("Untracked")]
        public bool IsUntracked { get; private set; }

        /// <summary>
        /// Site-relative path to the user's profile picture.
        /// </summary>
        [JsonInclude]
        public string UserPic { get; private set; } = string.Empty;

        /// <summary>
        /// User site motto.
        /// </summary>
        [JsonInclude]
        public string Motto { get; private set; } = string.Empty;

        /// <summary>
        /// If true, user allows comments to be posted to their wall.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(NumberApiToBooleanConverter))]
        [JsonPropertyName("UserWallActive")]
        public bool IsUserWallActive { get; private set; }

        /// <summary>
        /// Total number of ranked users.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("TotalRanked")]
        public int TotalRankedUsersCount { get; private set; }

        /// <summary>
        /// Unique identifier of last game user played.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("LastGameID")]
        public int LastGameId { get; private set; }

        /// <summary>
        /// Information about the last game the user played.
        /// </summary>
        [JsonInclude]
        public LastPlayedGame LastGame { get; private set; } = new LastPlayedGame();

        /// <summary>
        /// Activity information about the last game user played.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("RichPresenceMsg")]
        public string RichPresenceMessage { get; private set; } = string.Empty;

        /// <summary>
        /// Count of items in the RecentlyPlayed array.
        /// </summary>
        [JsonInclude]
        public int RecentlyPlayedCount { get; private set; }

        /// <summary>
        /// Collection of recently played games.
        /// </summary>
        [JsonInclude]
        public IReadOnlyCollection<RecentlyPlayedGame> RecentlyPlayed { get; private set; } = Array.Empty<RecentlyPlayedGame>();
        
        /// <summary>
        /// Data of user last activity.
        /// </summary>
        [JsonInclude]
        public LastActivity LastActivity { get; private set; } = new LastActivity();

        /// <summary>
        /// Current user status.
        /// </summary>
        [JsonInclude]
        public string Status { get; private set; } = string.Empty;

        /// <summary>
        /// Collection of earned awards (key: <see langword="GameId"/>).
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("Awarded")]
        public IDictionary<string, UserProgress> Awards { get; private set; } = new Dictionary<string, UserProgress>();

        /// <summary>
        /// Collection of recent achievements (key: <see langword="GameId"/>).
        /// </summary>
        [JsonInclude]
        public IDictionary<string, IDictionary<string, RecentAchievement>> RecentAchievements { get; private set; } = new Dictionary<string, IDictionary<string, RecentAchievement>>();

        /// <summary>
        /// Count of achievements won by others.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ContribCount")]
        public int ContributionCount { get; private set; }

        /// <summary>
        /// Count of points awarded to others.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ContribYield")]
        public int ContributionYield { get; private set; }
    }

    /// <summary>
    /// Data about recent achievement earned by the user.
    /// </summary>
    public record RecentAchievement
    {
        /// <summary>
        /// Unique identifier of the achievement.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        /// <summary>
        /// Title of the achievement
        /// </summary>
        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

        /// <summary>
        /// Description of the achievement
        /// </summary>
        [JsonInclude]
        public string Description { get; private set; } = string.Empty;

        /// <summary>
        /// Number of points the achievement is worth.
        /// </summary>
        [JsonInclude]
        public int Points { get; private set; }

        /// <summary>
        /// Unique identifier of the badge image for the achievement,
        /// </summary>
        [JsonInclude]
        public string BadgeName { get; private set; } = string.Empty;

        /// <summary>
        /// Unique identifier of the game
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("GameID")]
        public int GameId { get; private set; }

        /// <summary>
        /// Title of the game.
        /// </summary>
        [JsonInclude]
        public string GameTitle { get; private set; } = string.Empty;

        /// <summary>
        /// When the achievement was unlocked.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime DateAwarded { get; private set; }

        /// <summary>
        /// Is unlocked in hardcore mode.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("HardcoreAchieved")]
        [JsonConverter(typeof(NumberApiToBooleanConverter))]
        public bool? HardcoreMode { get; private set; }

    }

    /// <summary>
    /// Data of user last activity.
    /// </summary>
    public record LastActivity
    {
        /// <summary>
        /// Unique identifier of the activity.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        /// <summary>
        /// Date when the activity occured.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("timestamp")]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime? OccuredDate { get; private set; }

        /// <summary>
        /// Date when the activity was last modified.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("lastupdate")]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime? LastModifiedDate { get; private set; }

        /// <summary>
        /// User associated to activity
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("User")]
        public string Username { get; private set; } = string.Empty;

        /// <summary>
        /// Additional information about the activity.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("data")]
        public string? AdditionalInformation { get; private set; }

        /// <summary>
        /// Extra additional information about the activity.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("data2")]
        public string? ExtraAdditionalInformation { get; private set; }
    }

    /// <summary>
    /// Information about recently played game
    /// </summary>
    public record RecentlyPlayedGame
    {
        /// <summary>
        /// Unique identifier of the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("GameID")]
        public int Id { get; private set; }

        /// <summary>
        /// Name of the game.
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
        /// Name of the console
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
        /// Date when user last played the game.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        [JsonPropertyName("LastPlayed")]
        public DateTime LastPlayedDate { get; private set; }
    }

    /// <summary>
    /// Information about the last game the user played.
    /// </summary>
    public record LastPlayedGame
    {
        /// <summary>
        /// Unique identifier of the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        /// <summary>
        /// Name of the game.
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
        /// Name of the console
        /// </summary>
        [JsonInclude]
        public string ConsoleName { get; private set; } = string.Empty;

        /// <summary>
        /// Unique identifier of the official forum topic for the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ForumTopicID")]
        public int? ForumTopicId { get; private set; }

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
        /// Publisher of the game.
        /// </summary>
        [JsonInclude]
        public string Publisher { get; private set; } = string.Empty;

        /// <summary>
        /// Developer of the game.
        /// </summary>
        [JsonInclude]
        public string Developer { get; private set; } = string.Empty;

        /// <summary>
        /// Genre of the game.
        /// </summary>
        [JsonInclude]
        public string Genre { get; private set; } = string.Empty;

        /// <summary>
        /// Release date of the game.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        [JsonPropertyName("Released")]
        public DateTime ReleasedDate { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(NumberApiToBooleanConverter))]
        public bool IsFinal { get; private set; }
    }
}
