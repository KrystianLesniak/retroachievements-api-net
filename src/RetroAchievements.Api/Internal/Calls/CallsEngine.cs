using RetroAchievements.Api.Internal.Utils;
using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Internal.Calls
{
    internal class CallsEngine
    { 
        public async Task<IResponse> Call(RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData authenticationData, IRequest request)
        {
            ArgumentNullException.ThrowIfNull(client, nameof(client));
            ArgumentNullException.ThrowIfNull(authenticationData, nameof(authenticationData));
            ArgumentNullException.ThrowIfNull(request, nameof(request));


            var queries = await UrlBuilder.PrepareRequestQueries(
                authenticationData,
                new KeyValuePair<string, string>("i", request.GameId.ToString()));

            var response = await client.GetWithQueryStringAsync(await UrlBuilder.PrepareRequestUrl(ApiUrl), queries);

            var content = await response.Content.ReadAsStringAsync();

            var responseDto = new GetAchievementCountResponse(content, response.StatusCode);

            return responseDto;
        }
    }
}
