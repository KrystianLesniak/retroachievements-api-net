
using RetroAchievements.Api.Requests.Tickets;
using RetroAchievements.Api.Response.Tickets;

namespace RetroAchievements.Api
{
    public static class TicketsApi
    {
        #region GetTicketData
        public static async Task<GetTicketDataResponse> GetTicketDataAsync(this RetroAchievementsHttpClient client, int ticketId, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetTicketDataRequest(ticketId), authenticationData);
        }

        public static GetTicketDataResponse GetTicketData(this RetroAchievementsHttpClient client, int ticketId, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetTicketDataRequest(ticketId), authenticationData);
        }
        #endregion GetTicketData

        #region GetOpenTickets
        public static async Task<GetOpenTicketsResponse> GetOpenTicketsAsync(this RetroAchievementsHttpClient client, int offset = 0, int count = 10, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetOpenTicketsRequest(offset, count), authenticationData);
        }

        public static GetOpenTicketsResponse GetOpenTickets(this RetroAchievementsHttpClient client, int offset = 0, int count = 10, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetOpenTicketsRequest(offset, count), authenticationData);
        }
        #endregion GetOpenTickets
    }
}
