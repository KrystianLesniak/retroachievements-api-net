using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get information about all (max: <see langword="1000"/>) active set claims.
    /// </summary>
    public record GetActiveClaimsRequest : IRetroAchievementsRequest<GetActiveClaimsResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetActiveClaims";

        ///<inheritdoc cref="GetActiveClaimsRequest" />
        public GetActiveClaimsRequest()
        {
        }
    }
}
