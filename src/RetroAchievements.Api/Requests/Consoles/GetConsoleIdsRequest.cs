using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Consoles;

namespace RetroAchievements.Api.Requests.Consoles
{
    /// <summary>
    /// Get data collection of known consoles.
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
