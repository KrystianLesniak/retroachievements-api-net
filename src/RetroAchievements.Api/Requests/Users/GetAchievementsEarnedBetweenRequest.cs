using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    /// <summary>
    /// Get achievements earned by a user between two <see langword="DateTime"/>.
    /// </summary>
    public record GetAchievementsEarnedBetweenRequest : IRetroAchievementsRequest<GetAchievementsEarnedBetweenResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetAchievementsEarnedBetween";

        ///<inheritdoc cref="GetAchievementsEarnedBetweenRequest" />
        ///<param name="username"><inheritdoc cref="Username" path="/summary/node()"/></param>
        ///<param name="from"><inheritdoc cref="From" path="/summary/node()"/></param>
        ///<param name="to"><inheritdoc cref="To" path="/summary/node()"/></param>
        public GetAchievementsEarnedBetweenRequest(string username, DateTime from, DateTime to)
        {
            ArgumentNullException.ThrowIfNull(username);
            ArgumentNullException.ThrowIfNull(from);
            ArgumentNullException.ThrowIfNull(to);

            Username = username;
            From = from;
            To = to;
        }

        /// <summary>
        /// Username of a user.
        /// </summary>
        [ApiInputKey("u")]
        public string Username { get; init; }

        /// <summary>
        /// From when achievements was earned.
        /// </summary>

        [ApiInputKey("f", CustomOption.DateTimeToUnixSeconds)]
        public DateTime From { get; init; }

        /// <summary>
        /// Until when achievements was earned.
        /// </summary>
        [ApiInputKey("t", CustomOption.DateTimeToUnixSeconds)]
        public DateTime To { get; init; }
    }
}
