using RetroAchievements.Api.Request;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetUserClaimsRequest : IRetroAchievementsRequest
    {
        public GetUserClaimsRequest(string username)
        {
            ArgumentNullException.ThrowIfNull(username, nameof(username));

            Username = username;
        }

        public string RequestEndpoint => "API_GetUserClaims";

        [ApiInputKey("u")]
        public string Username { get; init; }
    }
}
