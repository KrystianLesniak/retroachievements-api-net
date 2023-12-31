﻿using RetroAchievements.Api.Exceptions;
using RetroAchievements.Api.Internal.Json;
using RetroAchievements.Api.Internal.Utils;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response;

namespace RetroAchievements.Api
{
    /// <inheritdoc cref="IRetroAchievementsHttpClient"/>
    public class RetroAchievementsHttpClient : IDisposable, IRetroAchievementsHttpClient
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

        /// <inheritdoc />
        public void SetAuthenticationData(IRetroAchievementsAuthenticationData authenticationData)
        {
            ArgumentNullException.ThrowIfNull(authenticationData, nameof(authenticationData));

            AuthenticationData = authenticationData;
        }

        /// <inheritdoc />
        public void RemoveAuthenticationData()
        {
            AuthenticationData = null;
        }

        /// <inheritdoc />
        public async Task<TResponse> SendAsync<TResponse>(IRetroAchievementsRequest<TResponse> request, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default) where TResponse : RetroAchievementsResponse, new()
        {
            ArgumentNullException.ThrowIfNull(request, nameof(request));

            using var httpRequest = CreateHttpRequest(request, authenticationData);

            using var response = await _httpClient.SendAsync(httpRequest, cancellationToken);
            using var contentStream = await response.Content.ReadAsStreamAsync(cancellationToken);

            return await ResponseBuilder.FromResponseAsync<TResponse>(contentStream, response.StatusCode, cancellationToken);
        }

        /// <inheritdoc />
        public TResponse Send<TResponse>(IRetroAchievementsRequest<TResponse> request, IRetroAchievementsAuthenticationData? authenticationData = null) where TResponse : RetroAchievementsResponse, new()
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

        /// <inheritdoc />
        public void Dispose()
        {
            _httpClient.Dispose();
            GC.SuppressFinalize(this);
        }
    }

    /// <summary>
    /// Provides a class for sending HTTP requests and receiving HTTP responses from a RetroAchievements API resources.
    /// </summary>
    public interface IRetroAchievementsHttpClient
    {
        /// <inheritdoc cref="HttpClient.Dispose(bool)"/>
        void Dispose();

        /// <summary>
        /// Remove previously set RetroAchievements authentication data.
        /// </summary>
        void RemoveAuthenticationData();

        /// <inheritdoc cref="SendAsync{TResponse}(IRetroAchievementsRequest{TResponse}, IRetroAchievementsAuthenticationData?, CancellationToken)"/>
        TResponse Send<TResponse>(IRetroAchievementsRequest<TResponse> request, IRetroAchievementsAuthenticationData? authenticationData = null) where TResponse : RetroAchievementsResponse, new();

        /// <summary>
        /// Calls passed RetroAchievements API request.
        /// </summary>
        /// <returns>Response data of called request.</returns>
        Task<TResponse> SendAsync<TResponse>(IRetroAchievementsRequest<TResponse> request, IRetroAchievementsAuthenticationData? authenticationData = null, CancellationToken cancellationToken = default) where TResponse : RetroAchievementsResponse, new();

        /// <summary>
        /// Set RetroAchievements authentication data required for API calls.
        /// </summary>
        /// <param name="authenticationData">RetroAchievements authentication data required for API calls.</param>
        void SetAuthenticationData(IRetroAchievementsAuthenticationData authenticationData);
    }
}