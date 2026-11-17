using RetroAchievements.Api.Internal.Json.Converters;
using RetroAchievements.Api.Response.Games.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games
{
    /// <summary>
    /// Extended data information about the game.
    /// </summary>
    public record GetGameExtendedDataResponse : RetroAchievementsResponse
    {
        /// <summary>
        /// Unique identifier of the game/
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
        /// Unique identifier of the parent game if this is a subset.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ParentGameID")]
        public int? ParentGameId { get; private set; }

        /// <summary>
        /// Count of unique players who have earned casual achievements for the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumDistinctPlayersCasual")]
        public int PlayersCasualCount { get; private set; }

        /// <summary>
        /// Count of unique players who have earned hardcore achievements for the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumDistinctPlayersHardcore")]
        public int PlayersHardcoreCount { get; private set; }

        /// <summary>
        /// Count of core achievements associated to the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumAchievements")]
        public int AchievementsCount { get; private set; }

        /// <summary>
        /// Achievements information collection.
        /// </summary>
        [JsonInclude]
        public IReadOnlyDictionary<int, GameAchievement> Achievements { get; private set; } = new Dictionary<int, GameAchievement>();

        /// <summary>
        /// Unique identifier of the official forum topic for the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ForumTopicID")]
        public int ForumTopicId { get; private set; }

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

        /// <summary>
        /// md5 of the script for generating the rich presence for the game.
        /// </summary>
        [JsonInclude]
        public string RichPresencePatch { get; private set; } = string.Empty;

        /// <summary>
        /// Claims collection for specified game.
        /// </summary>
        [JsonInclude]
        public IReadOnlyCollection<GameClaim> Claims { get; private set; } = Array.Empty<GameClaim>();

        /// <summary>
        /// Game flags.
        /// </summary>
        [JsonInclude]
        public int? Flags { get; private set; }

        /// <summary>
        /// Granularity of the release date (<see langword="day"/>, <see langword="month"/> or <see langword="year"/>).
        /// </summary>
        [JsonInclude]
        public string? ReleasedAtGranularity { get; private set; }

        /// <summary>
        /// Number of distinct players who have earned an achievement in the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("NumDistinctPlayers")]
        public int PlayersCount { get; private set; }

        /// <summary>
        /// URL to the game's guide.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("GuideURL")]
        public string? GuideUrl { get; private set; }

        /// <summary>
        /// Date the game was last updated.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        [JsonPropertyName("Updated")]
        public DateTime? UpdatedDate { get; private set; }
    }
}
