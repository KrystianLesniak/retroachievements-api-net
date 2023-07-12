
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Tickets;

namespace RetroAchievements.Api.Requests.Tickets
{
    /// <summary>
    /// TODO:
    /// </summary>
    public record GetGameTicketDataRequest : IRetroAchievementsRequest<GetGameTicketDataResponse>
    {
        public string RequestEndpoint => "API_GetTicketData";

        public GetGameTicketDataRequest(int gameId)
        {
            GameId = gameId;
        }

        [ApiInputKey("g")]
        public int GameId { get; init; }

        [ApiInputKey("f")]
        public int ConstApiFlag { get; init; } = 5;

        [ApiInputKey("d")]
        public int ConstApiDataFlag { get; init; } = 1;
    }
}
