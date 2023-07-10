//using RetroAchievements.Api.Request;

//namespace RetroAchievements.Api.Requests.Users
//{
//    public record GetUserRecentAchievementsRequest : IRetroAchievementsRequest
//    {
//        public GetUserRecentAchievementsRequest(string username, int minutesToLookBack = 60)
//        {
//            ArgumentNullException.ThrowIfNull(username, nameof(username));

//            Username = username;
//            MinutesToLookBack = minutesToLookBack;
//        }

//        public string RequestEndpoint => "API_GetUserRecentAchievements";

//        [ApiInputKey("u")]
//        public string Username { get; init; }

//        [ApiInputKey("m")]
//        public int MinutesToLookBack { get; init; }
//    }
//}
