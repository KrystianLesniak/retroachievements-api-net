using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Tests.Common
{
    public static class ApiLazyTestData
    {
        private static IReadOnlyCollection<User>? TopTenUsers;

        private static readonly IDictionary<string, GetUserAllGamesProgressResponse> UserAllGamesProgress = new Dictionary<string, GetUserAllGamesProgressResponse>();

        public static async Task<IReadOnlyCollection<User>> GetTopTenUsers(this IRetroAchievementsHttpClient httpClient)
        {
            TopTenUsers ??= (await httpClient.GetTopTenUsersAsync()).Items;

            return TopTenUsers;
        }

        public static async Task<GetUserAllGamesProgressResponse> GetUserAllGamesProgress(this IRetroAchievementsHttpClient httpClient, string userName)
        {
            if(UserAllGamesProgress.TryGetValue(userName, out GetUserAllGamesProgressResponse? value))
            {
                return value;
            }
            else
            {
                UserAllGamesProgress[userName] = await httpClient.GetUserAllGamesProgressAsync(userName);
                return UserAllGamesProgress[userName];
            }
        }
    }
}
