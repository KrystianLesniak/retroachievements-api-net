using RetroAchievements.Api.Internal.Json.Converters;
using RetroAchievements.Api.Response.Enums;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games.Records
{
    /// <summary>
    /// Claim data associated to the game.
    /// </summary>
    public record GameClaim
    {
        /// <summary>
        /// Username of user who made the claim.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("User")]
        public string Username { get; private set; } = string.Empty;


        /// <inheritdoc cref="Enums.ClaimType"/>
        [JsonInclude]
        public ClaimType ClaimType { get; private set; }

        /// <inheritdoc cref="Enums.SetType"/>
        [JsonInclude]
        public SetType SetType { get; private set; }

        /// <summary>
        /// Date the claim was made.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        [JsonPropertyName("Created")]
        public DateTime CreatedDate { get; private set; }

        /// <summary>
        /// Date when the claim will expire.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        [JsonPropertyName("Expiration")]
        public DateTime ExpirationDate { get; private set; }

    }
}
