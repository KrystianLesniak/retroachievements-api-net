
using RetroAchievements.Api.Requests.Tickets;
using RetroAchievements.Api.Response.Tickets;

namespace RetroAchievements.Api
{
    /// <summary>
    /// Class with extension methods for calling APIs from group "Tickets"
    /// </summary>
    public static class TicketsApi
    {
        #region GetTicketData
        /// <inheritdoc cref="GetTicketDataRequest(int)"/>
        public static async Task<GetTicketDataResponse> GetTicketDataAsync(this IRetroAchievementsHttpClient client, int ticketId, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetTicketDataRequest(ticketId), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetTicketDataRequest(int)"/>
        public static GetTicketDataResponse GetTicketData(this IRetroAchievementsHttpClient client, int ticketId, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetTicketDataRequest(ticketId), authenticationData);
        }
        #endregion GetTicketData

        #region GetOpenTickets
        /// <inheritdoc cref="GetOpenTicketsRequest(int, int)"/>
        public static async Task<GetOpenTicketsResponse> GetOpenTicketsAsync(this IRetroAchievementsHttpClient client, int offset = 0, int count = 10, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetOpenTicketsRequest(offset, count), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetOpenTicketsRequest(int, int)"/>
        public static GetOpenTicketsResponse GetOpenTickets(this IRetroAchievementsHttpClient client, int offset = 0, int count = 10, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetOpenTicketsRequest(offset, count), authenticationData);
        }
        #endregion GetOpenTickets

        #region GetGamesWithMostTickets
        /// <inheritdoc cref="GetGamesWithMostTicketsRequest(int, int)"/>
        public static async Task<GetGamesWithMostTicketsResponse> GetGamesWithMostTicketsAsync(this IRetroAchievementsHttpClient client, int offset = 0, int count = 10, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetGamesWithMostTicketsRequest(offset, count), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetGamesWithMostTicketsRequest(int, int)"/>
        public static GetGamesWithMostTicketsResponse GetGamesWithMostTickets(this IRetroAchievementsHttpClient client, int offset = 0, int count = 10, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGamesWithMostTicketsRequest(offset, count), authenticationData);
        }
        #endregion GetGamesWithMostTickets

        #region GetUserTicketData
        /// <inheritdoc cref="GetUserTicketDataRequest(string)"/>
        public static async Task<GetUserTicketDataResponse> GetUserTicketDataAsync(this IRetroAchievementsHttpClient client, string username, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetUserTicketDataRequest(username), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetUserTicketDataRequest(string)"/>
        public static GetUserTicketDataResponse GetUserTicketData(this IRetroAchievementsHttpClient client, string username, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetUserTicketDataRequest(username), authenticationData);
        }
        #endregion GetUserTicketData

        #region GetGameTicketData
        /// <inheritdoc cref="GetGameTicketDataRequest(int)"/>
        public static async Task<GetGameTicketDataResponse> GetGameTicketDataAsync(this IRetroAchievementsHttpClient client, int gameId, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetGameTicketDataRequest(gameId), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetGameTicketDataRequest(int)"/>
        public static GetGameTicketDataResponse GetGameTicketData(this IRetroAchievementsHttpClient client, int gameId, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGameTicketDataRequest(gameId), authenticationData);
        }
        #endregion GetGameTicketData

        #region GetAchievementTicketData
        /// <inheritdoc cref="GetAchievementTicketDataRequest(int)"/>
        public static async Task<GetAchievementTicketDataResponse> GetAchievementTicketDataAsync(this IRetroAchievementsHttpClient client, int achievementId, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default)
        {
            return await client.SendAsync(new GetAchievementTicketDataRequest(achievementId), authenticationData, cancellationToken);
        }

        /// <inheritdoc cref="GetAchievementTicketDataRequest(int)"/>
        public static GetAchievementTicketDataResponse GetAchievementTicketData(this IRetroAchievementsHttpClient client, int achievementId, IRetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetAchievementTicketDataRequest(achievementId), authenticationData);
        }
        #endregion GetAchievementTicketData
    }
}
