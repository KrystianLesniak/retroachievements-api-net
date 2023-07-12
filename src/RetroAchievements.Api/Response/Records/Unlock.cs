using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Records
{
    public record Unlock
    {
        [JsonInclude]
        public string User { get; private set; } = string.Empty;

        [JsonInclude]
        public int RAPoints { get; private set; }

        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime DateAwarded { get; private set; }

        [JsonInclude]
        [JsonConverter(typeof(NumberApiToBooleanConverter))]
        public bool HardcoreMode { get; private set; }
    }
}