using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Tests.Common
{
    public static class ApiLazyTestData
    {
        private static IReadOnlyCollection<User>? TopTenUsers;

        public static async Task<IReadOnlyCollection<User>> GetTopTenUsers(this IRetroAchievementsHttpClient httpClient)
        {
            TopTenUsers ??= (await httpClient.GetTopTenUsersAsync()).Items;

            return TopTenUsers;
        }
    }
}
