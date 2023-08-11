using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Internal.Json;
using RetroAchievements.Api.Internal.Utils;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response;

namespace RetroAchievements.Api
{
    /// <summary>
    /// Provides a class for sending HTTP requests and receiving HTTP responses from a RetroAchievements API resources.
    /// </summary>
    public class RetroAchievementsHttpClient : IDisposable
    {
        /// <summary>
        /// Initializes a new instance of <see cref="RetroAchievementsHttpClient"/> using a <see cref="HttpClient"/> that is disposed when this instance is disposed.
        /// </summary>
        public RetroAchievementsHttpClient()
        {
            _httpClient = new HttpClient();
        }

        /// <inheritdoc cref="RetroAchievementsHttpClient()"/>
        /// <param name="authenticationData">RetroAchievements authentication data required for API calls.</param>
        public RetroAchievementsHttpClient(IRetroAchievementsAuthenticationData authenticationData) : this()
        {
            SetAuthenticationData(authenticationData);
        }

        /// <inheritdoc cref="RetroAchievementsHttpClient()"/>
        public RetroAchievementsHttpClient(HttpClient httpClient)
        {
            ArgumentNullException.ThrowIfNull(httpClient, nameof(httpClient));

            _httpClient = httpClient;
        }

        /// <inheritdoc cref="RetroAchievementsHttpClient(IRetroAchievementsAuthenticationData)"/>
        public RetroAchievementsHttpClient(HttpClient httpClient, IRetroAchievementsAuthenticationData authenticationData) : this(httpClient)
        {
            SetAuthenticationData(authenticationData);
        }


        private IRetroAchievementsAuthenticationData? AuthenticationData { get; set; }

        private readonly HttpClient _httpClient;

        /// <summary>
        /// Set RetroAchievements authentication data required for API calls.
        /// </summary>
        /// <param name="authenticationData">RetroAchievements authentication data required for API calls.</param>
        public void SetAuthenticationData(IRetroAchievementsAuthenticationData authenticationData)
        {
            ArgumentNullException.ThrowIfNull(authenticationData, nameof(authenticationData));

            AuthenticationData = authenticationData;
        }

        /// <summary>
        /// Remove previously set RetroAchievements authentication data.
        /// </summary>
        public void RemoveAuthenticationData()
        {
            AuthenticationData = null;
        }

        internal async Task<TResponse> HandleRequestCallAsync<TResponse>(IRetroAchievementsRequest<TResponse> request, IRetroAchievementsAuthenticationData? authenticationData) where TResponse : RetroAchievementsResponse, new()
        {
            ArgumentNullException.ThrowIfNull(request, nameof(request));

            using var httpRequest = CreateHttpRequest(request, authenticationData);

            using var response = await _httpClient.SendAsync(httpRequest);
            using var contentStream = await response.Content.ReadAsStreamAsync();

            return await ResponseBuilder.FromResponseAsync<TResponse>(contentStream, response.StatusCode);
        }

        internal TResponse HandleRequestCall<TResponse>(IRetroAchievementsRequest<TResponse> request, IRetroAchievementsAuthenticationData? authenticationData) where TResponse : RetroAchievementsResponse, new()
        {
            ArgumentNullException.ThrowIfNull(request, nameof(request));

            using var httpRequest = CreateHttpRequest(request, authenticationData);

            using var response = _httpClient.Send(httpRequest);
            using var contentStream = response.Content.ReadAsStream();

            return ResponseBuilder.FromResponse<TResponse>(contentStream, response.StatusCode);
        }

        private HttpRequestMessage CreateHttpRequest<TResponse>(IRetroAchievementsRequest<TResponse> request, IRetroAchievementsAuthenticationData? authenticationData) where TResponse : RetroAchievementsResponse, new()
        {
            var authData = authenticationData
                ?? AuthenticationData
                ?? throw new MissingAuthenticationDataException();

            var queries = RequestHelper.GetQueries(authData, request);
            var url = UrlBuilder.PrepareRequestUrlWithQuery(request.RequestEndpoint, queries);

            return new HttpRequestMessage(HttpMethod.Get, url);
        }

        /// <inheritdoc cref="HttpClient.Dispose(bool)"/>
        public void Dispose()
        {
            _httpClient.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}