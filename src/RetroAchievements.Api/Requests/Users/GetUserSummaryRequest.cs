﻿//using RetroAchievements.Api.Request;

//namespace RetroAchievements.Api.Requests.Users
//{
//    public record GetUserSummaryRequest : IRetroAchievementsRequest
//    {
//        public GetUserSummaryRequest(string username, int recentGamesToReturn = 5, int recentAchievementsToReturn = 10)
//        {
//            ArgumentNullException.ThrowIfNull(username, nameof(username));

//            Username = username;
//            RecentGamesToReturn = recentGamesToReturn;
//            RecentAchievementsToReturn = recentAchievementsToReturn;
//        }

//        public string RequestEndpoint => "API_GetUserSummary";

//        [ApiInputKey("u")]
//        public string Username { get; init; }

//        [ApiInputKey("g")]
//        public int RecentGamesToReturn { get; init; }

//        [ApiInputKey("a")]
//        public int RecentAchievementsToReturn { get; init; }
//    }
//}
