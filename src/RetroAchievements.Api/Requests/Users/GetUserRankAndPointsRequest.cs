using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get information about user number of points and rank.
    /// </summary>
    public record GetUserRankAndPointsRequest : IRetroAchievementsRequest<GetUserRankAndPointsResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetUserRankAndScore";

        ///<inheritdoc cref="GetUserRankAndPointsRequest" />
        ///<param name="username"><inheritdoc cref="Username" path="/summary/node()"/></param>
        public GetUserRankAndPointsRequest(string username)
        {
            ArgumentExceptionGuard.ThrowIfNullOrWhitespace(username, nameof(username));

            Username = username;
        }

        /// <summary>
        /// Username of the user.
        /// </summary>

        [ApiInputKey("u")]
        public string Username { get; init; }
    }
}
