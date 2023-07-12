
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Tickets;

namespace RetroAchievements.Api.Requests.Tickets
{
    public record GetUserTicketDataRequest : IRetroAchievementsRequest<GetUserTicketDataResponse>
    {
        public string RequestEndpoint => "API_GetTicketData";

        public GetUserTicketDataRequest(string username)
        {
            ArgumentNullException.ThrowIfNull(username);

            Username = username;
        }

        [ApiInputKey("u")]
        public string Username { get; init; }
    }
}
