using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get summary information about a given user, targeted by username.
    /// </summary>
    public record GetUserSummaryRequest : IRetroAchievementsRequest<GetUserSummaryResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetUserSummary";

        ///<inheritdoc cref="GetUserSummaryRequest" />
        ///<param name="username"><inheritdoc cref="Username" path="/summary/node()"/></param>
        ///<param name="recentGamesToReturn"><inheritdoc cref="RecentGamesToReturn" path="/summary/node()"/></param>
        ///<param name="recentAchievementsToReturn"><inheritdoc cref="RecentAchievementsToReturn" path="/summary/node()"/></param>
        public GetUserSummaryRequest(string username, int recentGamesToReturn = 0, int recentAchievementsToReturn = 10)
        {
            ArgumentExceptionGuard.ThrowIfNullOrWhitespace(username, nameof(username));

            Username = username;
            RecentGamesToReturn = recentGamesToReturn;
            RecentAchievementsToReturn = recentAchievementsToReturn;
        }

        /// <summary>
        /// Username of an user to seek data for.
        /// </summary>
        [ApiInputKey("u")]
        public string Username { get; init; }

        /// <summary>
        /// Number of recent games to return (default: <see langword="0"/>)
        /// </summary>
        [ApiInputKey("g")]
        public int RecentGamesToReturn { get; init; }

        /// <summary>
        /// Number of recent achievements to return (default: <see langword="10"/>)
        /// </summary>
        [ApiInputKey("a")]
        public int RecentAchievementsToReturn { get; init; }
    }
}
