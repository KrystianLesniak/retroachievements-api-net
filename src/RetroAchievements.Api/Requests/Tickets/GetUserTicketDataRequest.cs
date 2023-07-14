
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Tickets;

namespace RetroAchievements.Api.Requests.Tickets
{
    /// <summary>
    /// Get ticket statistics data for the specified user.
    /// </summary>
    public record GetUserTicketDataRequest : IRetroAchievementsRequest<GetUserTicketDataResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetTicketData";

        ///<inheritdoc cref="GetUserTicketDataRequest" />
        ///<param name="username"><inheritdoc cref="Username" path="/summary/node()"/></param>
        public GetUserTicketDataRequest(string username)
        {
            ArgumentNullException.ThrowIfNull(username);

            Username = username;
        }

        /// <summary>
        /// Username of user to seek tickets data for.
        /// </summary>
        [ApiInputKey("u")]
        public string Username { get; init; }
    }
}
