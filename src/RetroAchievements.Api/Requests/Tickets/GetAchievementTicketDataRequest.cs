
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Tickets;

namespace RetroAchievements.Api.Requests.Tickets
{
    /// <summary>
    /// TODO:
    /// </summary>
    public record GetAchievementTicketDataRequest : IRetroAchievementsRequest<GetAchievementTicketDataResponse>
    {
        public string RequestEndpoint => "API_GetTicketData";

        public GetAchievementTicketDataRequest(int achievementId)
        {
            AchievementId = achievementId;
        }

        [ApiInputKey("a")]
        public int AchievementId { get; init; }

    }
}
