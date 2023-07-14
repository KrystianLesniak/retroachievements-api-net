using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// User achieved points.
    /// </summary>
    public record GetUserPointsResponse : RetroAchievementsResponse
    {
        /// <summary>
        /// Number of hardcore points the user has.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("Points")]
        public int HardcorePoints { get; private set; }

        /// <summary>
        /// Number of softcore points the user has.
        /// </summary>
        [JsonInclude]
        public int SoftcorePoints { get; private set; }

    }
}
