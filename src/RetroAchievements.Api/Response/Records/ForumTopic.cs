using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Records
{
    /// <summary>
    /// Data about the forum topic.
    /// </summary>
    public record ForumTopic
    {
        /// <summary>
        /// Unique identifier of the forum topic.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }
    }
}
