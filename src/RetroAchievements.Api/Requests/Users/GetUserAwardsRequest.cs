using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get data about the user's earned awards.
    /// </summary>
    public record GetUserAwardsRequest : IRetroAchievementsRequest<GetUserAwardsResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetUserAwards";

        ///<inheritdoc cref="GetUserAwardsRequest" />
        ///<param name="username"><inheritdoc cref="Username" path="/summary/node()"/></param>
        public GetUserAwardsRequest(string username)
        {
            ArgumentNullException.ThrowIfNull(username, nameof(username));

            Username = username;
        }

        /// <summary>
        /// Username of the user.
        /// </summary>
        [ApiInputKey("u")]
        public string Username { get; init; }
    }
}
