using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api
{
    public static class BaseApi
    {

        public static async Task<TResponse> SendAsync<TResponse>(this RetroAchievementsHttpClient client, IRetroAchievementsRequest<TResponse> request, RetroAchievementsAuthenticationData? authenticationData = null) where TResponse : RetroAchievementsResponse, new()
        {
            return await client.HandleRequestCallAsync(request, authenticationData);
        }

        public static TResponse Send<TResponse>(this RetroAchievementsHttpClient client, IRetroAchievementsRequest<TResponse> request, RetroAchievementsAuthenticationData? authenticationData = null) where TResponse : RetroAchievementsResponse, new()
        {
            return client.HandleRequestCall(request, authenticationData);
        }

    }
}
