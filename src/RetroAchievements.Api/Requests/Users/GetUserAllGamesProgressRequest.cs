using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get games progress for specified user.
    /// </summary>
    public record GetUserAllGamesProgressRequest : IRetroAchievementsRequest<GetUserAllGamesProgressResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetUserCompletedGames";


        ///<inheritdoc cref="GetUserAwardsRequest" />
        ///<param name="username"><inheritdoc cref="Username" path="/summary/node()"/></param>
        public GetUserAllGamesProgressRequest(string username)
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
