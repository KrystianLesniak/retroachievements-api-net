using RetroAchievements.Api.Internal.Utils;
using RetroAchievements.Api.Requests.Users;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Internal.Calls.Users
{
    internal class GetAchievementsEarnedBetweenCall : ICall<GetAchievementsEarnedBetweenRequest, GetAchievementsEarnedBetweenResponse>
    {
        public string ApiUrl { get; set; } = "API_GetAchievementsEarnedBetween.php";

        public async Task<GetAchievementsEarnedBetweenResponse> Call(RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData authenticationData, GetAchievementsEarnedBetweenRequest request)
        {
            ArgumentNullException.ThrowIfNull(client, nameof(client));
            ArgumentNullException.ThrowIfNull(authenticationData, nameof(authenticationData));
            ArgumentNullException.ThrowIfNull(request, nameof(request));

            var queries = await UrlBuilder.PrepareRequestQueries(
                authenticationData,
                new KeyValuePair<string, string>("u", request.User),
                new KeyValuePair<string, string>("f", request.From.ToString("Y-m-d H:i:s")),
                new KeyValuePair<string, string>("t", request.To.ToString("Y-m-d H:i:s")));

            var url = await UrlBuilder.PrepareRequestUrl(ApiUrl);

            var response = await client.GetWithQueryStringAsync(url, queries);
            
            //TODO: Redact whole response
            var content =  await response.Content.ReadAsStringAsync();

            return new GetAchievementsEarnedBetweenResponse();
        }
    }
}
