using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get data about points for specified user.
    /// </summary>
    public record GetUserPointsRequest : IRetroAchievementsRequest<GetUserPointsResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetUserPoints";


        ///<inheritdoc cref="GetUserPointsRequest" />
        ///<param name="username"><inheritdoc cref="Username" path="/summary/node()"/></param>
        public GetUserPointsRequest(string username)
        {
            ArgumentExceptionGuard.ThrowIfNullOrWhitespace(username, nameof(username));

            Username = username;
        }

        /// <summary>
        /// Username of user.
        /// </summary>
        [ApiInputKey("u")]
        public string Username { get; init; }
    }
}
