using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetAchievementsEarnedOnDayRequest : IRetroAchievementsRequest<GetAchievementsEarnedOnDayResponse>
    {
        public string RequestEndpoint => "API_GetAchievementsEarnedOnDay";

        public GetAchievementsEarnedOnDayRequest(string user, DateTime date)
        {
            ArgumentNullException.ThrowIfNull(user);

            User = user;
            Date = date;
        }

        [ApiInputKey("u")]
        public string User { get; init; }

        [ApiInputKey("d", CustomOption.DateTimeToShortDate)]
        public DateTime Date { get; init; }
    }
}
