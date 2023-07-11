
using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Tickets;

namespace RetroAchievements.Api.Requests.Tickets
{
    public record GetOpenTicketsRequest : IRetroAchievementsRequest<GetOpenTicketsResponse>
    {
        public string RequestEndpoint => "API_GetTicketData";

        public GetOpenTicketsRequest(int offset = 0, int count = 10)
        {
            ArgumentExceptionGuard.ThrowIfGreaterThan(count, nameof(count), 100);

            Offset = offset;
            Count = count;
        }

        [ApiInputKey("o")]
        public int Offset { get; init; }

        [ApiInputKey("c")]
        public int Count { get; init; }
    }
}
