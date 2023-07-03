using RetroAchievements.Api.Internal.Utils;
using RetroAchievements.Api.Requests.Users;
using RetroAchievements.Api.Response.Users;
using System.Security.Principal;
using System.Text.Json;

namespace RetroAchievements.Api.Internal.Calls.Users
{
    internal class GetAchievementCountCall : ICall<GetAchievementCountRequest, GetAchievementCountResponse>
    {
        public string ApiUrl { get; set; } = "API_GetAchievementCount.php";

        public async Task<GetAchievementCountResponse> Call(RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData authenticationData, GetAchievementCountRequest request)
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
