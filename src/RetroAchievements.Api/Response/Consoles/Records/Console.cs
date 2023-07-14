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
    }
}
