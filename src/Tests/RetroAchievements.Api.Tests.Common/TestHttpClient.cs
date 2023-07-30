namespace RetroAchievements.Api.Tests.Common
{
    public static class TestHttpClient
    {
        private static RetroAchievementsHttpClient? HttpClient;

        public static RetroAchievementsHttpClient GetRetroAchievementsApiClient(IRetroAchievementsAuthenticationData? authData = null)
        {
            if(HttpClient == null)
            {
                if(authData == null)
                    HttpClient = new RetroAchievementsHttpClient(TestAuthenticationData.CreateFromSecrets());
                else
                    HttpClient = new RetroAchievementsHttpClient(authData);
            }

            return HttpClient;
        }
    }
}
