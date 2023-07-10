using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetUserCompletedGamesRequest : IRetroAchievementsRequest<GetUserCompletedGamesResponse>
    {
        public GetUserCompletedGamesRequest(string username)
        {
            ArgumentNullException.ThrowIfNull(username, nameof(username));

            Username = username;
        }

        public string RequestEndpoint => "API_GetUserCompletedGames";

        [ApiInputKey("u")]
        public string Username { get; init; }
    }
}
