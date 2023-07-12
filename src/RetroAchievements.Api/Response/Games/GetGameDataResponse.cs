using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games
{
    /// <summary>
    /// Data information about the game.
    /// </summary>
    public record GetGameDataResponse : RetroAchievementsResponse
    {
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
        /// Unique identifier of the official forum topic for the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ForumTopicID")]
        public int ForumTopicId { get; private set; }

        /// <summary>
        /// Site-relative path to the game's icon image.
        /// </summary>
        [JsonInclude]
        public string GameIcon { get; private set; } = string.Empty;

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
        public string ImageIngame { get; private set; } = string.Empty;

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
    }
}
