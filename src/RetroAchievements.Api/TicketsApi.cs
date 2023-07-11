
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
    }
}
