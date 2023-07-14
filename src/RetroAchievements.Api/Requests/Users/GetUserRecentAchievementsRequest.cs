using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get collection of achievements recently earned by an user.
    /// </summary>
    public record GetUserRecentAchievementsRequest : IRetroAchievementsRequest<GetUserRecentAchievementsResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetUserRecentAchievements";

        ///<inheritdoc cref="GetUserRecentAchievementsRequest" />
        ///<param name="username"><inheritdoc cref="Username" path="/summary/node()"/></param>
        ///<param name="minutesToLookBack"><inheritdoc cref="MinutesToLookBack" path="/summary/node()"/></param>
        public GetUserRecentAchievementsRequest(string username, int minutesToLookBack = 60)
        {
            ArgumentNullException.ThrowIfNull(username, nameof(username));

            Username = username;
            MinutesToLookBack = minutesToLookBack;
        }

        /// <summary>
        /// Username of the user.
        /// </summary>
        [ApiInputKey("u")]
        public string Username { get; init; }

        /// <summary>
        /// Minutes to look back (default: <see langword="60"/>).
        /// </summary>
        [ApiInputKey("m")]
        public int MinutesToLookBack { get; init; }
    }
}
