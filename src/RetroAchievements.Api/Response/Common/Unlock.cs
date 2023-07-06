using RetroAchievements.Api.Internal.Json;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Common
{
    public record Unlock
    {
        [JsonInclude]
        public string User { get; private set; } = string.Empty;

        [JsonInclude]
        public int RAPoints { get; private set; }

        [JsonConverter(typeof(DateTimeConverterForCustomApiFormat))]
        [JsonInclude]
        public DateTime DateAwarded { get; private set; }

        [JsonInclude]
        public int HardcoreMode { get; private set; }
    }
}