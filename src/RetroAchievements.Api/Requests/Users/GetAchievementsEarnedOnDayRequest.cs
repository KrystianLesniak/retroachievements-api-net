using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get achievements earned by a user on specified date.
    /// </summary>
    public record GetAchievementsEarnedOnDayRequest : IRetroAchievementsRequest<GetAchievementsEarnedOnDayResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetAchievementsEarnedOnDay";

        ///<inheritdoc cref="GetAchievementsEarnedOnDayRequest" />
        ///<param name="user"><inheritdoc cref="User" path="/summary/node()"/></param>
        ///<param name="date"><inheritdoc cref="Date" path="/summary/node()"/></param>
        public GetAchievementsEarnedOnDayRequest(string user, DateTime date)
        {
            ArgumentNullException.ThrowIfNull(user);

            User = user;
            Date = date;
        }

        /// <summary>
        /// Username of a user.
        /// </summary>
        [ApiInputKey("u")]
        public string User { get; init; }

        /// <summary>
        /// Date when achievements was earned.
        /// </summary>
        [ApiInputKey("d", CustomOption.DateTimeToShortDate)]
        public DateTime Date { get; init; }
    }
}
