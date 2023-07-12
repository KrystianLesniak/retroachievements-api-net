using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// TODO:
    /// </summary>
    public record GetAchievementOfTheWeekRequest : IRetroAchievementsRequest<GetAchievementOfTheWeekResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetAchievementOfTheWeek";

        ///<inheritdoc cref="GetAchievementOfTheWeekRequest" />
        public GetAchievementOfTheWeekRequest()
        {
        }
    }
}
