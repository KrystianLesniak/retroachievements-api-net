using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Profile summary information about the user.
    /// </summary>
    public record GetUserProfileResponse : RetroAchievementsResponse
    {
        /// <summary>
        /// Username of the user.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("User")]
        public string Username { get; private set; } = string.Empty;

        /// <summary>
        /// Unique, stable identifier (ULID) of the user.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ULID")]
        public string? Ulid { get; private set; }

        /// <summary>
        /// Site-relative path to the user's profile picture.
        /// </summary>
        [JsonInclude]
        public string UserPic { get; private set; } = string.Empty;

        /// <summary>
        /// Date when the user joined the site.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime MemberSince { get; private set; }

        /// <summary>
        /// Activity information about the last game user played.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("RichPresenceMsg")]
        public string RichPresenceMessage { get; private set; } = string.Empty;

        /// <summary>
        /// Unique identifier of last game user played.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("LastGameID")]
        public int? LastGameId { get; private set; }

        /// <summary>
        /// Count of achievements won by others.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ContribCount")]
        public int ContributionCount { get; private set; }

        /// <summary>
        /// Count of points awarded to others.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ContribYield")]
        public int ContributionYield { get; private set; }

        /// <summary>
        /// Total hardcore points earned by the user.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("TotalPoints")]
        public int TotalHardcorePoints { get; private set; }

        /// <summary>
        /// Total softcore points earned by the user.
        /// </summary>
        [JsonInclude]
        public int TotalSoftcorePoints { get; private set; }

        /// <summary>
        /// Total "white" points earned by the user.
        /// </summary>
        [JsonInclude]
        public int TotalTruePoints { get; private set; }

        /// <summary>
        /// Unique identifier of user's account type.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("Permissions")]
        public int PermissionsId { get; private set; }

        /// <summary>
        /// Is user untracked.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(NumberApiToBooleanConverter))]
        [JsonPropertyName("Untracked")]
        public bool IsUntracked { get; private set; }

        /// <summary>
        /// Unique identifier of the user.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int UserId { get; private set; }

        /// <summary>
        /// If true, user allows comments to be posted to their wall.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(NumberApiToBooleanConverter))]
        [JsonPropertyName("UserWallActive")]
        public bool IsUserWallActive { get; private set; }

        /// <summary>
        /// User site motto.
        /// </summary>
        [JsonInclude]
        public string Motto { get; private set; } = string.Empty;
    }
}
