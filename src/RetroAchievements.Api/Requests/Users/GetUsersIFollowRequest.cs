using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get the users the authenticated user is following.
    /// </summary>
    public record GetUsersIFollowRequest : IRetroAchievementsRequest<GetUsersIFollowResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetUsersIFollow";

        ///<inheritdoc cref="GetUsersIFollowRequest" />
        ///<param name="offset"><inheritdoc cref="Offset" path="/summary/node()"/></param>
        ///<param name="count"><inheritdoc cref="Count" path="/summary/node()"/></param>
        public GetUsersIFollowRequest(int offset = 0, int count = 100)
        {
            ArgumentExceptionGuard.ThrowIfGreaterThan(count, nameof(count), 500);

            Offset = offset;
            Count = count;
        }

        /// <summary>
        /// Number of entries to skip (default: <see langword="0"/>)
        /// </summary>
        [ApiInputKey("o")]
        public int Offset { get; init; }

        /// <summary>
        /// Number of entries to return (default: <see langword="100"/>, max: <see langword="500"/>)
        /// </summary>
        [ApiInputKey("c")]
        public int Count { get; init; }
    }
}
