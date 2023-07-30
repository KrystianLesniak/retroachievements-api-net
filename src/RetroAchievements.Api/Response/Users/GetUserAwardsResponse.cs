using RetroAchievements.Api.Response.Users.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Data about the user's earned awards.
    /// </summary>
    public record GetUserAwardsResponse : RetroAchievementsResponse
    {
        /// <summary>
        /// Count of awards earned by the user, including hidden.
        /// </summary>
        [JsonInclude]
        public int TotalAwardsCount { get; private set; }

        /// <summary>
        /// Count of awards hidden by the user.
        /// </summary>
        [JsonInclude]
        public int HiddenAwardsCount { get; private set; }

        /// <summary>
        /// Count of game mastery awards earned by the user.
        /// </summary>
        [JsonInclude]
        public int MasteryAwardsCount { get; private set; }

        /// <summary>
        /// Count of game completion awards earned by the user (softcore mastery).
        /// </summary>
        [JsonInclude]
        public int CompletionAwardsCount { get; private set; }

        /// <summary>
        /// Count of awards currently appearing in the user's Event Awards section.
        /// </summary>
        [JsonInclude]
        public int EventAwardsCount { get; private set; }

        /// <summary>
        /// Count of awards currently appearing in the user's Site Awards section.
        /// </summary>
        [JsonInclude]
        public int SiteAwardsCount { get; private set; }

        /// <summary>
        /// Collection of visible user awards.
        /// </summary>
        [JsonInclude]
        public IReadOnlyCollection<VisibleUserAward> VisibleUserAwards { get; private set; } = Array.Empty<VisibleUserAward>();
    }
}
