using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get data about specified user set claims.
    /// </summary>
    public record GetUserClaimsRequest : IRetroAchievementsRequest<GetUserClaimsResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetUserClaims";


        ///<inheritdoc cref="GetUserClaimsRequest" />
        ///<param name="username"><inheritdoc cref="Username" path="/summary/node()"/></param>
        public GetUserClaimsRequest(string username)
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
