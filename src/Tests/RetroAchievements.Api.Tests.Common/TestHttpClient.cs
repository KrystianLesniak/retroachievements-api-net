namespace RetroAchievements.Api.Tests.Common
{
    public static class TestHttpClient
    {
        private static RetroAchievementsHttpClient? HttpClient;

        public static RetroAchievementsHttpClient GetRetroAchievementsApiClient()
        {
            if (HttpClient == null)
            {
                var netHttpClient = HttpClientFactory.Create(new DelayHandler());

                HttpClient = new RetroAchievementsHttpClient(netHttpClient, TestAuthenticationData.CreateFromSecrets());
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

        private const int RequestDelayMiliseconds = 100;
        private readonly int RequestAwaitMilisecond = RequestDelayMiliseconds / Environment.ProcessorCount;

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            while (IsRequestOngoing)
            {
                await Task.Delay(RequestAwaitMilisecond, cancellationToken);
            }

            IsRequestOngoing = true;

            var response = await base.SendAsync(request, cancellationToken);
            while(response.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
            {
                await Task.Delay(RequestDelayMiliseconds, cancellationToken);
                response = base.Send(request, cancellationToken);
            }

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
            while (response.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
            {
                Thread.Sleep(RequestDelayMiliseconds);
                response = base.Send(request, cancellationToken);
            }

            IsRequestOngoing = false;

            return response;
        }
    }
}
