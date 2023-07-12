using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Consoles;

namespace RetroAchievements.Api.Requests.Consoles
{
    /// <summary>
    /// TODO:
    /// </summary>
    public record GetConsoleIdsRequest : IRetroAchievementsRequest<GetConsoleIdsResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetConsoleIDs";

        ///<inheritdoc cref="GetConsoleIdsRequest" />
        public GetConsoleIdsRequest()
        {
        }
    }
}
