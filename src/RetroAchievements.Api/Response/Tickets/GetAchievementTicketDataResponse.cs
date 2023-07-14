using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Tickets
{
    /// <summary>
    /// Ticket statistics for specific achievement.
    /// </summary>
    public record GetAchievementTicketDataResponse : RetroAchievementsResponse
    {
        /// <summary>
        /// Unique identifier of the achievement.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("AchievementID")]
        public int AchievementId { get; private set; }

        /// <summary>
        /// Title of the achievement.
        /// </summary>
        [JsonInclude]
        public string AchievementTitle { get; private set; } = string.Empty;

        /// <summary>
        /// Description of the achievement.
        /// </summary>
        [JsonInclude]
        public string AchievementDescription { get; private set; } = string.Empty;

        /// <summary>
        /// Count of open tickets.
        /// </summary>
        [JsonInclude]
        public int OpenTicketsCount { get; private set; }

        /// <summary>
        /// URL to the list of tickets associated to the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("URL")]
        public string Url { get; private set; } = string.Empty;

    }
}
