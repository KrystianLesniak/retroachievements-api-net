﻿using RetroAchievements.Api.Internal.Utils;
using RetroAchievements.Api.Request;
using System.Net;

namespace RetroAchievements.Api
{
    public class RetroAchievementsHttpClient : HttpClient
    {
        public RetroAchievementsHttpClient() : base()
        {
        }
        public RetroAchievementsHttpClient(IRetroAchievementsAuthenticationData authenticationData) : this()
        {
            SetAuthenticationData(authenticationData);
        }

        public RetroAchievementsHttpClient(HttpMessageHandler handler) : base(handler)
        {
        }

        public RetroAchievementsHttpClient(HttpMessageHandler handler, IRetroAchievementsAuthenticationData authenticationData) : this(handler)
        {
            SetAuthenticationData(authenticationData);
        }


        internal IRetroAchievementsAuthenticationData? AuthenticationData { get; private set; }

        public void SetAuthenticationData(IRetroAchievementsAuthenticationData authenticationData)
        {
            ArgumentNullException.ThrowIfNull(authenticationData, nameof(authenticationData));

            AuthenticationData = authenticationData;
        }

        public void RemoveAuthenticationData()
        {
            AuthenticationData = null;
        }

        internal async Task<(string, HttpStatusCode)> HandleRequestCall(IRequest request, IRetroAchievementsAuthenticationData? authenticationData)
        {
            ArgumentNullException.ThrowIfNull(request, nameof(request));
            var auth = ValidateAuthenticationData(authenticationData);

            var queries = await UrlBuilder.PrepareRequestQueries(auth, request);
            var url = await UrlBuilder.PrepareRequestUrl(request.RequestEndpoint);

            using var response = await this.GetWithQueryStringAsync(url, queries);

            return (await response.Content.ReadAsStringAsync(), response.StatusCode);
        }

        private IRetroAchievementsAuthenticationData ValidateAuthenticationData(IRetroAchievementsAuthenticationData? authenticationData)
        {
            //TODO: Create custom exception for no Authentication Data

            return authenticationData
                ?? AuthenticationData
                ?? throw new ArgumentNullException();
        }
    }
}