using RetroAchievements.Api.Request;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetAchievementOfTheWeekRequest : IRequest
    {
        public string RequestEndpoint => "API_GetAchievementOfTheWeek";

        public GetAchievementOfTheWeekRequest()
        {
        }
    }
}
