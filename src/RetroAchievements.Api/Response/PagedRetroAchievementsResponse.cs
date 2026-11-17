using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response
{
    /// <summary>
    /// RetroAchievements API paginated Response Data.
    /// </summary>
    public record PagedRetroAchievementsResponse<TItem> : RetroAchievementsResponse
    {
        /// <summary>
        /// Count of items returned in <see cref="Results"/>.
        /// </summary>
        [JsonInclude]
        public int Count { get; private set; }

        /// <summary>
        /// Total count of items available.
        /// </summary>
        [JsonInclude]
        public int Total { get; private set; }

        /// <summary>
        /// Collection of items returned from API request call.
        /// </summary>
        [JsonInclude]
        public IReadOnlyCollection<TItem> Results { get; private set; } = Array.Empty<TItem>();
    }
}
