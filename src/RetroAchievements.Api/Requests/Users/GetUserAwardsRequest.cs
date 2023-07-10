using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetUserAwardsRequest : IRetroAchievementsRequest<GetUserAwardsResponse>
    {
        public string RequestEndpoint => "API_GetUserAwards";

        public GetUserAwardsRequest(string username)
        {
            ArgumentNullException.ThrowIfNull(username, nameof(username));

            Username = username;
        }

        [ApiInputKey("u")]
        public string Username { get; init; }
    }
}
