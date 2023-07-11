using RetroAchievements.Api.Internal.Json.Converters;
using RetroAchievements.Api.Response.Enums;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games.Records
{
    public record GameClaim
    {
        [JsonInclude]
        public string User { get; private set; } = string.Empty;


        [JsonInclude]
        public ClaimType ClaimType { get; private set; }

        [JsonInclude]
        public SetType SetType { get; private set; }

        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime Created { get; private set; }

        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime Expiration { get; private set; }

    }
}
