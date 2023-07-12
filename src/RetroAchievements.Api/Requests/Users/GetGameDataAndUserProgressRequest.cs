//using RetroAchievements.Api.Request;
//using RetroAchievements.Api.Response.Users;

//namespace RetroAchievements.Api.Requests.Users
//{
//    TODO: Request disabled until issue will be resolved: https://github.com/RetroAchievements/retroachievements-api-js/issues/46
//    public record GetGameInfoAndUserProgressRequest : IRetroAchievementsRequest<GetGameInfoAndUserProgressResponse>
//    {
//        public string RequestEndpoint => "API_GetGameInfoAndUserProgress";

//        public GetGameInfoAndUserProgressRequest(int gameId, string username)
//        {
//            ArgumentNullException.ThrowIfNull(gameId, nameof(gameId));
//            ArgumentNullException.ThrowIfNull(username, nameof(username));

//            GameId = gameId;
//            Username = username;
//        }

//        [ApiInputKey("g")]
//        public int GameId { get; init; }

//        [ApiInputKey("u")]
//        public string Username { get; init; }
//    }
//}
