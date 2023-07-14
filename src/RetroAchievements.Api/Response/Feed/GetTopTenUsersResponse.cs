using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Collection of data about top ten users (by score) for the site.
    /// </summary>
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<User, GetTopTenUsersResponse>))]
    public record GetTopTenUsersResponse : CollectionRetroAchievementsResponse<User>
    {
    }

    /// <summary>
    /// Statistics for top user for the site.
    /// </summary>
    public record User
    {
        /// <summary>
        /// Username of the user.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("1")]
        public string Username { get; private set; } = String.Empty;

        /// <summary>
        /// Total points earned by the user.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("2")]
        public int TotalPoints { get; private set; }

        /// <summary>
        /// Total "white" points earned by the user.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("3")]
        public int TotalWhitePoints { get; private set; }
    }
}
