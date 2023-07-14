
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Tickets;

namespace RetroAchievements.Api.Requests.Tickets
{
    /// <summary>
    /// Get ticket data for the specified game.
    /// </summary>
    public record GetGameTicketDataRequest : IRetroAchievementsRequest<GetGameTicketDataResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetTicketData";

        ///<inheritdoc cref="GetGameTicketDataRequest" />
        ///<param name="gameId"><inheritdoc cref="GameId" path="/summary/node()"/></param>
        public GetGameTicketDataRequest(int gameId)
        {
            GameId = gameId;
        }

        /// <summary>
        /// Unique identifier of the game.
        /// </summary>
        [ApiInputKey("g")]
        public int GameId { get; init; }

        /// <summary>
        /// Internal API Flag
        /// </summary>
        [ApiInputKey("d")]
        public int ConstApiDataFlag { get; init; } = 1;
    }
}
