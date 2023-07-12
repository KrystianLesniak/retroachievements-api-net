using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Records
{
    /// <summary>
    /// Data about the console associated to the game associated to the achievemnt.
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
        [JsonPropertyName("Title")]
        public string Name { get; private set; } = string.Empty;
    }
}
