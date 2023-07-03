using RetroAchievements.Api.Request;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetAchievementsEarnedBetweenRequest : IRequest
    {
        public GetAchievementsEarnedBetweenRequest(string user, DateTime from, DateTime to)
        {
            ArgumentNullException.ThrowIfNull(user);
            ArgumentNullException.ThrowIfNull(from);
            ArgumentNullException.ThrowIfNull(to);

            User = user;
            From = from;
            To = to;
        }

        public string User { get; init; }
        public DateTime From { get; init; }
        public DateTime To { get; init; }
    }
}
