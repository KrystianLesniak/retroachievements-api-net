using RetroAchievements.Api.Request;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetAchievementsEarnedOnDayRequest : IRetroAchievementsRequest
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
