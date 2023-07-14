
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Tickets;

namespace RetroAchievements.Api.Requests.Tickets
{
    /// <summary>
    /// Get details data for a specific ticket.
    /// </summary>
    public record GetTicketDataRequest : IRetroAchievementsRequest<GetTicketDataResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetTicketData";

        ///<inheritdoc cref="GetTicketDataRequest" />
        ///<param name="ticketId"><inheritdoc cref="TicketId" path="/summary/node()"/></param>
        public GetTicketDataRequest(int ticketId)
        {
            ArgumentNullException.ThrowIfNull(ticketId);

            TicketId = ticketId;
        }

        /// <summary>
        /// Ticket identifier.
        /// </summary>
        [ApiInputKey("i")]
        public int TicketId { get; init; }
    }
}
