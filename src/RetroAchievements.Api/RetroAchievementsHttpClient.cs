using RetroAchievements.Api.Internal.Utils;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api
{
    public class RetroAchievementsHttpClient : IDisposable
    {
        internal HttpClient HttpClient { get; private set; } = new HttpClient();
        internal RetroAchievementsAuthenticationData? AuthenticationData { get; private set; }

        public void Dispose()
        {
            HttpClient.Dispose();
            GC.SuppressFinalize(this); //informing GC that this object was cleaned up fully.
        }

        internal async Task<HttpResponseMessage> HandleRequestCall(IRequest request, RetroAchievementsAuthenticationData? authenticationData)
        {
            ArgumentNullException.ThrowIfNull(request, nameof(request));
            //TODO: Guard against null Authentication Data

            var queries = await UrlBuilder.PrepareRequestQueries(authenticationData ?? AuthenticationData, request);
            var url = await UrlBuilder.PrepareRequestUrl(request.RequestEndpoint);

            var response = await HttpClient.GetWithQueryStringAsync(url, queries);

            return response;
        }
    }
}