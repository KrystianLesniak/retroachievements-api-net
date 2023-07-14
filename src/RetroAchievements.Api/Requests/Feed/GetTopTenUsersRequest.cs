using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get data about top ten users (by score) for the site.
    /// </summary>
    public record GetTopTenUsersRequest : IRetroAchievementsRequest<GetTopTenUsersResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetTopTenUsers";

        ///<inheritdoc cref="GetTopTenUsersRequest" />
        public GetTopTenUsersRequest()
        {
        }
    }
}
