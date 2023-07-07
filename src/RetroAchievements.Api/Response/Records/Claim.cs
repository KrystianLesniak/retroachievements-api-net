using RetroAchievements.Api.Internal.Json.Converters;
using RetroAchievements.Api.Response.Enums;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Common
{
    public record Claim
    {
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        [JsonInclude]
        public string User { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonPropertyName("GameID")]
        public int GameId { get; private set; }

        [JsonInclude]
        public string GameTitle { get; private set; } = string.Empty;

        [JsonInclude]
        public string GameIcon { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonPropertyName("ConsoleID")]
        public int ConsoleId { get; private set; }

        [JsonInclude]
        public string ConsoleName { get; private set; } = string.Empty;

        [JsonInclude]
        public ClaimType ClaimType { get; private set; }

        [JsonInclude]
        public SetType SetType { get; private set; }

        [JsonInclude]
        public Status Status { get; private set; }

        [JsonInclude]
        public int Extension { get; private set; }

        [JsonInclude]
        public int Special { get; private set; }

        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime Created { get; private set; }

        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime DoneTime { get; private set; }

        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime Updated { get; private set; }

        [JsonInclude]
        [JsonConverter(typeof(NumberApiToBooleanConverter))]
        public bool UserIsJrDev { get; private set; }

        [JsonInclude]
        public int MinutesLeft { get; private set; }
    }
}
