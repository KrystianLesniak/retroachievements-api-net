using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response;

namespace RetroAchievements.Api
{
    /// <summary>
    /// Class with extension methods for calling APIs with Request class
    /// </summary>
    public static class BaseApi
    {
        /// <summary>
        /// Calls passed RetroAchievements API request.
        /// </summary>
        /// <returns>Response data of called request.</returns>
        public static async Task<TResponse> SendAsync<TResponse>(this RetroAchievementsHttpClient client, IRetroAchievementsRequest<TResponse> request, RetroAchievementsAuthenticationData? authenticationData = null) where TResponse : RetroAchievementsResponse, new()
        {
            return await client.HandleRequestCallAsync(request, authenticationData);
        }

        /// <inheritdoc cref="SendAsync{TResponse}(RetroAchievementsHttpClient, IRetroAchievementsRequest{TResponse}, RetroAchievementsAuthenticationData?)"/>
        public static TResponse Send<TResponse>(this RetroAchievementsHttpClient client, IRetroAchievementsRequest<TResponse> request, RetroAchievementsAuthenticationData? authenticationData = null) where TResponse : RetroAchievementsResponse, new()
        {
            return client.HandleRequestCall(request, authenticationData);
        }

    }
}
