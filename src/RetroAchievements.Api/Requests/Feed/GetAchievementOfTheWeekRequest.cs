using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetAchievementOfTheWeekRequest : IRetroAchievementsRequest<GetAchievementOfTheWeekResponse>
    {
        public string RequestEndpoint => "API_GetAchievementOfTheWeek";

        public GetAchievementOfTheWeekRequest()
        {
        }
    }
}
