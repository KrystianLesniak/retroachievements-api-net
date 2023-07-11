
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Tickets;

namespace RetroAchievements.Api.Requests.Tickets
{
    public record GetTicketDataRequest : IRetroAchievementsRequest<GetTicketDataResponse>
    {
        public string RequestEndpoint => "API_GetTicketData";

        public GetTicketDataRequest(int ticketId)
        {
            ArgumentNullException.ThrowIfNull(ticketId);

            TicketId = ticketId;
        }

        [ApiInputKey("i")]
        public int TicketId { get; init; }
    }
}
