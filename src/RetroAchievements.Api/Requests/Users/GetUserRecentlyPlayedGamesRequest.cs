//using RetroAchievements.Api.Request;

//namespace RetroAchievements.Api.Requests.Users
//{
//    public record GetUserRecentlyPlayedGamesRequest : IRetroAchievementsRequest
//    {
//        public GetUserRecentlyPlayedGamesRequest(string username, int offset = 0, int count = 10)
//        {
//            ArgumentNullException.ThrowIfNull(username, nameof(username));

//            if (count > 50)
//                throw new ArgumentException($"{nameof(count)} property should not be greater than 50." );

//            Username = username;
//            Offset = offset;
//            Count = count;
//        }

//        public string RequestEndpoint => "API_GetUserRecentlyPlayedGames";

//        [ApiInputKey("u")]
//        public string Username { get; init; }

//        [ApiInputKey("o")]
//        public int Offset { get; init; }

//        [ApiInputKey("c")]
//        public int Count { get; init; }
//    }
//}
