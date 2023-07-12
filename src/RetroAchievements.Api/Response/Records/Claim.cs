using RetroAchievements.Api.Internal.Json.Converters;
using RetroAchievements.Api.Response.Enums;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Records
{
    /// <summary>
    /// Data about RetroAchievements Claim.
    /// </summary>
    public record Claim
    {
        /// <summary>
        /// Identifier of the claim.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        /// <summary>
        /// Username of user who made the claim.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("User")]
        public string Username { get; private set; } = string.Empty;

        /// <summary>
        /// Identifier of the claimed game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("GameID")]
        public int GameId { get; private set; }

        /// <summary>
        /// Title of the claimed game.
        /// </summary>
        [JsonInclude]
        public string GameTitle { get; private set; } = string.Empty;

        /// <summary>
        /// Site-relative path to the game's icon image.
        /// </summary>
        [JsonInclude]
        public string GameIcon { get; private set; } = string.Empty;

        /// <summary>
        /// Console id of the claimed game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("ConsoleID")]
        public int ConsoleId { get; private set; }

        /// <summary>
        /// Console name of the claimed game.
        /// </summary>
        [JsonInclude]
        public string ConsoleName { get; private set; } = string.Empty;

        /// <inheritdoc cref="Enums.ClaimType"/>
        [JsonInclude]
        public ClaimType ClaimType { get; private set; }

        /// <inheritdoc cref="Enums.SetType"/>
        [JsonInclude]
        public SetType SetType { get; private set; }

        /// <inheritdoc cref="Enums.ClaimStatus"/>
        [JsonInclude]
        public ClaimStatus Status { get; private set; }

        /// <summary>
        /// Count of times when the claim has been extended.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("Extension")]
        public int ExtensionsCount { get; private set; }

        /// <summary>
        /// Flag indicating a special type of claim
        /// </summary>
        [JsonInclude]
        public int Special { get; private set; }

        /// <summary>
        /// Date the claim was made.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        [JsonPropertyName("Created")]
        public DateTime CreatedDate { get; private set; }

        /// <summary>
        /// Date the claim is done.
        /// </summary>
        /// <remarks>
        /// Expiration date for active claims. <br />
        /// Completion date for complete claims. <br />
        /// Dropped date for dropped claims.
        /// </remarks>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime DoneTime { get; private set; }

        /// <summary>
        /// Date the claim was updated.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        [JsonPropertyName("Updated")]
        public DateTime UpdatedDate { get; private set; }

        /// <summary>
        /// Is user a junior dev.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(NumberApiToBooleanConverter))]
        [JsonPropertyName("UserIsJrDev")]
        public bool UserIsJuniorDev { get; private set; }

        /// <summary>
        /// Time in minutes left until the claim expires.
        /// </summary>
        [JsonInclude]
        public int MinutesLeft { get; private set; }
    }
}
