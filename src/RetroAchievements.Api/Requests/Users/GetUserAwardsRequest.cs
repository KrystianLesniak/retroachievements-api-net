//using RetroAchievements.Api.Request;

//namespace RetroAchievements.Api.Requests.Users
//{
//    public record GetUserAwardsRequest : IRetroAchievementsRequest
//    {
//        public string RequestEndpoint => "API_GetUserAwards";

//        public GetUserAwardsRequest(string username)
//        {
//            ArgumentNullException.ThrowIfNull(username, nameof(username));

//            Username = username;
//        }

//        [ApiInputKey("u")]
//        public string Username { get; init; }
//    }
//}
