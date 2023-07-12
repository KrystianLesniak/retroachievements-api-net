using RetroAchievements.Api.Response.Users.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    public record GetUserAwardsResponse : RetroAchievementsResponse
    {
        [JsonInclude]
        public int TotalAwardsCount { get; private set; }

        [JsonInclude]
        public int HiddenAwardsCount { get; private set; }

        [JsonInclude]
        public int MasteryAwardsCount { get; private set; }

        [JsonInclude]
        public int CompletionAwardsCount { get; private set; }

        [JsonInclude]
        public int EventAwardsCount { get; private set; }

        [JsonInclude]
        public int SiteAwardsCount { get; private set; }

        [JsonInclude]
        public IReadOnlyCollection<VisibleUserAward> VisibleUserAwards { get; private set; } = new List<VisibleUserAward>();
    }
}
