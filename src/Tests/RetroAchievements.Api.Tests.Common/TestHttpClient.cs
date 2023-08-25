namespace RetroAchievements.Api.Tests.Common
{
    public static class TestHttpClient
    {
        private static RetroAchievementsHttpClient? HttpClient;

        public static RetroAchievementsHttpClient GetRetroAchievementsApiClient(IRetroAchievementsAuthenticationData? authData = null)
        {
            if (HttpClient == null)
            {
                var netHttpClient = HttpClientFactory.Create(new DelayHandler());

                if (authData == null)
                    HttpClient = new RetroAchievementsHttpClient(netHttpClient, TestAuthenticationData.CreateFromSecrets());
                else
                    HttpClient = new RetroAchievementsHttpClient(netHttpClient, authData);
            }

            return HttpClient;
        }


    }

    //RetroAchievements upon many requests send back HTTP Error 429 = Too many requests
    //This exists to prevent it so all API Tests may be run in parallel but request are not send simultaneously
    //It's not really betufil solution, might be written better but it's only related to Tests performance ;p
    public class DelayHandler : DelegatingHandler
    {
        private bool IsRequestOngoing = false;

        private const int RequestDelayMiliseconds = 75;
        private readonly int RequestAwaitMilisecond = RequestDelayMiliseconds / Environment.ProcessorCount;

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            while (IsRequestOngoing)
            {
                await Task.Delay(RequestAwaitMilisecond, cancellationToken);
            }

            IsRequestOngoing = true;

            var response = await base.SendAsync(request, cancellationToken);

            await Task.Delay(RequestDelayMiliseconds, cancellationToken);

            IsRequestOngoing = false;
            return response;
        }

        protected override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            while (IsRequestOngoing)
            {
                Thread.Sleep(RequestAwaitMilisecond);
            }

            IsRequestOngoing = true;

            var response = base.Send(request, cancellationToken);

            Thread.Sleep(RequestDelayMiliseconds);

            IsRequestOngoing = false;

            return response;
        }
    }
}
