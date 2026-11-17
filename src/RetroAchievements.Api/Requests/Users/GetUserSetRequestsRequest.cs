using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;
using RetroAchievements.Api.Requests.Enums;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get the set requests made by the user.
    /// </summary>
    public record GetUserSetRequestsRequest : IRetroAchievementsRequest<GetUserSetRequestsResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetUserSetRequests";

        ///<inheritdoc cref="GetUserSetRequestsRequest" />
        ///<param name="username"><inheritdoc cref="Username" path="/summary/node()"/></param>
        ///<param name="requestListType"><inheritdoc cref="RequestListType" path="/summary/node()"/></param>
        public GetUserSetRequestsRequest(string username, RequestListType requestListType = RequestListType.ActiveRequests)
        {
            ArgumentExceptionGuard.ThrowIfNullOrWhitespace(username, nameof(username));

            Username = username;
            RequestListType = requestListType;
        }

        /// <summary>
        /// Username of an user to seek data for.
        /// </summary>
        [ApiInputKey("u")]
        public string Username { get; init; }

        /// <summary>
        /// Type of the set requests list.
        /// </summary>
        [ApiInputKey("t")]
        public RequestListType RequestListType { get; init; }
    }
}
