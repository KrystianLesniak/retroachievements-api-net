using RetroAchievements.Api.Internal.Calls;
using RetroAchievements.Api.Internal.Calls.Users;
using RetroAchievements.Api.Requests.Users;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Users
{
    public static class UsersApi
    {
        private static readonly Lazy<ICall<GetAchievementsEarnedBetweenRequest, GetAchievementsEarnedBetweenResponse>> _getAchievementsEarnedBetweenCall = new(() => new GetAchievementsEarnedBetweenCall());
        public static async Task<GetAchievementsEarnedBetweenResponse> GetAchievementsEarnedBetween(this RetroAchievementsClient client, RetroAchievementsAuthenticationData authenticationData, string gameId)
                => await GetAchievementsEarnedBetween(client, authenticationData, new GetAchievementsEarnedBetweenRequest(gameId));

        public static async Task<GetAchievementsEarnedBetweenResponse> GetAchievementsEarnedBetween(this RetroAchievementsClient client, RetroAchievementsAuthenticationData authenticationData, GetAchievementsEarnedBetweenRequest request)
                => await _getAchievementsEarnedBetweenCall.Value.Call(client, authenticationData, request);
    }
}
