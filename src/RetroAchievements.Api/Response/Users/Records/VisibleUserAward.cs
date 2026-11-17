using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users.Records
{
    /// <summary>
    /// Visible award of user.
    /// </summary>
    public record VisibleUserAward
    {
        /// <summary>
        /// When the user earned the award.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        [JsonPropertyName("AwardedAt")]
        public DateTime AwardedDate { get; private set; }

        /// <summary>
        /// Type of award.
        /// </summary>
        [JsonInclude]
        public string AwardType { get; private set; } = string.Empty;

        /// <summary>
        /// Typically an ID, such as for a game.
        /// </summary>
        [JsonInclude]
        public int AwardData { get; private set; }

        /// <summary>
        /// 1 if it's a Mastery, not a Completion.
        /// </summary>
        [JsonInclude]
        public int AwardDataExtra { get; private set; }

        /// <summary>
        /// Order the award appears on the user's profile.
        /// </summary>
        [JsonInclude]
        public int DisplayOrder { get; private set; }

        /// <summary>
        /// Name of the award, such as the game name if a Mastery/Completion.
        /// </summary>
        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

        /// <summary>
        /// Name of the console associated with the award.
        /// </summary>
        [JsonInclude]
        public string ConsoleName { get; private set; } = string.Empty;

        /// <summary>
        /// Site-relative path to the award's icon image.
        /// </summary>
        [JsonInclude]
        public string ImageIcon { get; private set; } = string.Empty;

        /// <summary>
        /// Unique identifier of the console associated to the award.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ConsoleID")]
        public int? ConsoleId { get; private set; }

        /// <summary>
        /// Award flags.
        /// </summary>
        [JsonInclude]
        public int? Flags { get; private set; }

        /// <summary>
        /// Display tier of the award.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("display_award_tier")]
        public int? DisplayAwardTier { get; private set; }
    }
}