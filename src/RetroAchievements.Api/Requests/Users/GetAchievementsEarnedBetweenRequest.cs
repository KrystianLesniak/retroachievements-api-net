using RetroAchievements.Api.Request;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetAchievementsEarnedBetweenRequest : IRetroAchievementsRequest
    {
        public string RequestEndpoint => "API_GetAchievementsEarnedBetween";

        public GetAchievementsEarnedBetweenRequest(string user, DateTime from, DateTime to)
        {
            ArgumentNullException.ThrowIfNull(user);
            ArgumentNullException.ThrowIfNull(from);
            ArgumentNullException.ThrowIfNull(to);

            User = user;
            From = from;
            To = to;
        }

        [ApiInputKey("u")]
        public string User { get; init; }

        [ApiInputKey("f")]
        public DateTime From { get; init; }

        [ApiInputKey("t")]
        public DateTime To { get; init; }
    }
}
