using RetroAchievements.Api.Internal.Json.Converters;
using RetroAchievements.Api.Response.Feed.Records;
using RetroAchievements.Api.Response.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    public record GetAchievementOfTheWeekResponse : RetroAchievementsResponse
    {
        [JsonInclude]
        public Achievement Achievement { get; private set; } = new();

        [JsonInclude]
        public Response.Records.Console Console { get; private set; } = new();

        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime StartAt { get; private set; }

        [JsonInclude]
        public int UnlocksCount { get; private set; }

        [JsonInclude]
        public int TotalPlayers { get; private set; }

        [JsonInclude]
        public IEnumerable<Unlock> Unlocks { get; private set; } = new List<Unlock>();
    }
}
