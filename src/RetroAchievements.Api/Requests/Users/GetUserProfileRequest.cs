using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get summary information about a given user, targeted by username.
    /// </summary>
    public record GetUserProfileRequest : IRetroAchievementsRequest<GetUserProfileResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetUserProfile";

        ///<inheritdoc cref="GetUserProfileRequest" />
        ///<param name="username"><inheritdoc cref="Username" path="/summary/node()"/></param>
        public GetUserProfileRequest(string username)
        {
            ArgumentExceptionGuard.ThrowIfNullOrWhitespace(username, nameof(username));

            Username = username;
        }

        /// <summary>
        /// Username of an user to seek data for.
        /// </summary>
        [ApiInputKey("u")]
        public string Username { get; init; }
    }
}
