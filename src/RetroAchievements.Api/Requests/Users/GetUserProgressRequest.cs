using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;


namespace RetroAchievements.Api.Requests.Users
{
    public record GetUserProgressRequest : IRetroAchievementsRequest<GetUserProgressResponse>
    {
        public GetUserProgressRequest(string username, IEnumerable<int> gameIds)
        {
            ArgumentNullException.ThrowIfNull(username, nameof(username));
            ArgumentNullException.ThrowIfNull(gameIds, nameof(gameIds));
            ArgumentExceptionGuard.ThrowIfEmpty(gameIds, nameof(gameIds));

            Username = username;
            GameIds = gameIds;
        }

        public string RequestEndpoint => "API_GetUserProgress";

        [ApiInputKey("u")]
        public string Username { get; init; }

        [ApiInputKey("i")]
        public IEnumerable<int> GameIds { get; init; }
    }
}
