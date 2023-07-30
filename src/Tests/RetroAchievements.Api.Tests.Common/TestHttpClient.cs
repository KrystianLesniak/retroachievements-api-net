namespace RetroAchievements.Api.Tests.Common
{
    public static class TestHttpClient
    {
        private static RetroAchievementsHttpClient? HttpClient;

        public static RetroAchievementsHttpClient GetRetroAchievementsApiClient(IRetroAchievementsAuthenticationData? authData = null)
        {
            if(HttpClient == null)
            {
                var netHttpClient = HttpClientFactory.Create(new HttpClientHandler()
                {
                    MaxConnectionsPerServer = 1
                }, 
                new DelayHandler());

                if (authData == null)
                    HttpClient = new RetroAchievementsHttpClient(netHttpClient, TestAuthenticationData.CreateFromSecrets());
                else
                    HttpClient = new RetroAchievementsHttpClient(netHttpClient, authData);
            }

            return HttpClient;
        }


    }

    public class DelayHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            await Task.Delay(100, cancellationToken);
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
