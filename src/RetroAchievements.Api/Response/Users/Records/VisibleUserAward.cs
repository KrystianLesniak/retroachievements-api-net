using RetroAchievements.Api.Internal.Json.Converters;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users.Records
{
    public record VisibleUserAward
    {
        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime AwardedAt { get; private set; }

        [JsonInclude]
        public string AwardType { get; private set; } = string.Empty;

        [JsonInclude]
        public int AwardData { get; private set; }

        [JsonInclude]
        public int AwardDataExtra { get; private set; }

        [JsonInclude]
        public int DisplayOrder { get; private set; }

        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

        [JsonInclude]
        public string ConsoleName { get; private set; } = string.Empty;

        [JsonInclude]
        public string ImageIcon { get; private set; } = string.Empty;

    }
}