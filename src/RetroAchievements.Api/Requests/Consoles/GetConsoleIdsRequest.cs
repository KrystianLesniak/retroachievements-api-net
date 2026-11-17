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
        ///<param name="onlyActive"><inheritdoc cref="OnlyActive" path="/summary/node()"/></param>
        ///<param name="onlyGameSystems"><inheritdoc cref="OnlyGameSystems" path="/summary/node()"/></param>
        public GetConsoleIdsRequest(bool onlyActive = false, bool onlyGameSystems = false)
        {
            OnlyActive = onlyActive ? 1 : 0;
            OnlyGameSystems = onlyGameSystems ? 1 : 0;
        }

        /// <summary>
        /// Only return consoles that are active (receiving achievements).
        /// </summary>
        [ApiInputKey("a")]
        public int OnlyActive { get; init; }

        /// <summary>
        /// Only return game systems (excludes e.g. Hubs and Events).
        /// </summary>
        [ApiInputKey("g")]
        public int OnlyGameSystems { get; init; }
    }
}
