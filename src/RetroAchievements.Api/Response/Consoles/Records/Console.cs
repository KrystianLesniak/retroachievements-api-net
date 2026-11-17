using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Consoles.Records
{
    /// <summary>
    /// Data about known console.
    /// </summary>
    public record Console
    {
        /// <summary>
        /// Unique identifier of the console.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        /// <summary>
        /// Name of the console.
        /// </summary>
        [JsonInclude]
        public string Name { get; private set; } = string.Empty;

        /// <summary>
        /// Absolute URL to the console's icon image.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("IconURL")]
        public string IconUrl { get; private set; } = string.Empty;

        /// <summary>
        /// Is the console active (receiving achievements) on RetroAchievements.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("Active")]
        public bool IsActive { get; private set; }

        /// <summary>
        /// Is the console a game system (not e.g. Hubs or Events).
        /// </summary>
        [JsonInclude]
        public bool IsGameSystem { get; private set; }
    }
}
