using RetroAchievements.Api.Internal.Utils;
using RetroAchievements.Api.Requests.Users;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Internal.Calls.Users
{
    internal class GetAchievementsEarnedBetweenCall : ICall<GetAchievementsEarnedBetweenRequest, GetAchievementsEarnedBetweenResponse>
    {
        public string ApiUrl { get; set; } = "API_GetAchievementCount.php";

        public async Task<GetAchievementsEarnedBetweenResponse> Call(RetroAchievementsClient client, RetroAchievementsAuthenticationData authenticationData, GetAchievementsEarnedBetweenRequest request)
        {
            ArgumentNullException.ThrowIfNull(client, nameof(client));
            ArgumentNullException.ThrowIfNull(authenticationData, nameof(authenticationData));
            ArgumentNullException.ThrowIfNull(request, nameof(request));

            var queries = await UrlBuilder.PrepareRequestQueries(
                authenticationData,
                new KeyValuePair<string, string>("i", request.GameId));

            var url = await UrlBuilder.PrepareRequestUrl(ApiUrl);

            var response = await client.HttpClient.GetWithQueryStringAsync(url, queries);

            var content=  await response.Content.ReadAsStringAsync();

            return new GetAchievementsEarnedBetweenResponse();
        }
    }
}
