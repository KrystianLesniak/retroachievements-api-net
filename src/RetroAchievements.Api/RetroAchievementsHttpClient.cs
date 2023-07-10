using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Internal.Json;
using RetroAchievements.Api.Internal.Utils;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response;

namespace RetroAchievements.Api
{
    public class RetroAchievementsHttpClient : IDisposable
    {
        public RetroAchievementsHttpClient()
        {
            _httpClient = new HttpClient();
        }
        public RetroAchievementsHttpClient(IRetroAchievementsAuthenticationData authenticationData) : this()
        {
            SetAuthenticationData(authenticationData);
        }

        public RetroAchievementsHttpClient(HttpClient httpClient)
        {
            ArgumentNullException.ThrowIfNull(httpClient, nameof(httpClient));

            _httpClient = httpClient;
        }

        public RetroAchievementsHttpClient(HttpClient httpClient, IRetroAchievementsAuthenticationData authenticationData) : this(httpClient)
        {
            SetAuthenticationData(authenticationData);
        }


        private IRetroAchievementsAuthenticationData? AuthenticationData { get; set; }

        private readonly HttpClient _httpClient;
        private readonly ResponseBuilder responseBuilder = new();

        public void SetAuthenticationData(IRetroAchievementsAuthenticationData authenticationData)
        {
            ArgumentNullException.ThrowIfNull(authenticationData, nameof(authenticationData));

            AuthenticationData = authenticationData;
        }

        public void RemoveAuthenticationData()
        {
            AuthenticationData = null;
        }

        internal async Task<TResponse> HandleRequestCallAsync<TResponse>(IRetroAchievementsRequest<TResponse> request, IRetroAchievementsAuthenticationData? authenticationData) where TResponse : RetroAchievementsResponse, new()
        {
            ArgumentNullException.ThrowIfNull(request, nameof(request));
            var auth = ValidateAuthenticationData(authenticationData);

            var queries = HttpClientHelper.PrepareRequestQueries(auth, request);
            var url = HttpClientHelper.PrepareRequestUrl(request.RequestEndpoint);

            using var response = await _httpClient.GetWithQueryStringAsync(url, queries);
            using var contentStream = await response.Content.ReadAsStreamAsync();

            return await responseBuilder.FromResponseAsync<TResponse>(contentStream, response.StatusCode);
        }

        internal TResponse HandleRequestCall<TResponse>(IRetroAchievementsRequest<TResponse> request, IRetroAchievementsAuthenticationData? authenticationData) where TResponse : RetroAchievementsResponse, new()
        {
            ArgumentNullException.ThrowIfNull(request, nameof(request));
            var auth = ValidateAuthenticationData(authenticationData);

            var queries = HttpClientHelper.PrepareRequestQueries(auth, request);
            var url = HttpClientHelper.PrepareRequestUrl(request.RequestEndpoint);

            using var response = _httpClient.GetWithQueryString(url, queries);
            using var contentStream = response.Content.ReadAsStream();

            return responseBuilder.FromResponse<TResponse>(contentStream, response.StatusCode);
        }

        private IRetroAchievementsAuthenticationData ValidateAuthenticationData(IRetroAchievementsAuthenticationData? authenticationData)
        {
            return authenticationData
                ?? AuthenticationData
                ?? throw new MissingAuthenticationDataException();
        }

        public void Dispose()
        {
            _httpClient.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}