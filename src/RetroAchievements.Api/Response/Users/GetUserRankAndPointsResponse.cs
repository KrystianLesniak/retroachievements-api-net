using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Information data about user number of points and rank.
    /// </summary>
    public record GetUserRankAndPointsResponse : RetroAchievementsResponse
    {
        /// <summary>
        /// Number of hardcore points the user has.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("Score")]
        public int HardcorePoints { get; private set; }

        /// <summary>
        /// Number of softcore points the user has.
        /// </summary>
        [JsonInclude]
        public int SoftcorePoints { get; private set; }

        /// <summary>
        /// User's site rank.
        /// </summary>
        [JsonInclude]
        public int Rank { get; private set; }

        /// <summary>
        /// Total number of ranked users.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("TotalRanked")]
        public int TotalRankedUsersCount { get; private set; }

    }
}
