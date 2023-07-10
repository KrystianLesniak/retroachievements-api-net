using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Users;

namespace RetroAchievements.Api.Requests.Users
{
    public record GetUserClaimsRequest : IRetroAchievementsRequest<GetUserClaimsResponse>
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
