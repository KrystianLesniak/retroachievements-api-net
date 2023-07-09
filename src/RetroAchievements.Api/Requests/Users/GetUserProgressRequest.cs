using RetroAchievements.Api.Request;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetUserProgressRequest : IRetroAchievementsRequest
    {
        public GetUserProgressRequest(string username, IEnumerable<int> gameIds)
        {
            ArgumentNullException.ThrowIfNull(username, nameof(username));
            ArgumentNullException.ThrowIfNull(gameIds, nameof(gameIds));

            Username = username;
            GameIds = gameIds;
        }

        public string RequestEndpoint => "API_GetUserProgress";

        [ApiInputKey("u")]
        public string Username { get; init; }

        //TODO: Add support for CSV: collect(explode(',', $gameCSV))
        [ApiInputKey("i")]
        public IEnumerable<int> GameIds { get; init; }
    }
}
