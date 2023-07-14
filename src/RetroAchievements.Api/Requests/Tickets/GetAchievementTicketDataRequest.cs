
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Tickets;

namespace RetroAchievements.Api.Requests.Tickets
{
    /// <summary>
    /// Get ticket statistics data for the specified achievement.
    /// </summary>
    public record GetAchievementTicketDataRequest : IRetroAchievementsRequest<GetAchievementTicketDataResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetTicketData";

        ///<inheritdoc cref="GetAchievementTicketDataRequest" />
        ///<param name="achievementId"><inheritdoc cref="AchievementId" path="/summary/node()"/></param>
        public GetAchievementTicketDataRequest(int achievementId)
        {
            AchievementId = achievementId;
        }

        /// <summary>
        /// Unique identifier of achievement.
        /// </summary>
        [ApiInputKey("a")]
        public int AchievementId { get; init; }

    }
}
