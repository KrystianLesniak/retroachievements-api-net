using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Consoles;

namespace RetroAchievements.Api.Requests.Consoles
{
    /// <summary>
    /// TODO:
    /// </summary>
    public record GetGameListRequest : IRetroAchievementsRequest<GetGameListResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetGameList";

        ///<inheritdoc cref="GetGameListRequest" />
        ///<param name="consoleId"><inheritdoc cref="ConsoleId" path="/summary/node()"/></param>
        ///<param name="onlyWithAchievements"><inheritdoc cref="OnlyWithAchievements" path="/summary/node()"/></param>
        ///<param name="getHashes"><inheritdoc cref="GetHashes" path="/summary/node()"/></param>
        public GetGameListRequest(int consoleId, bool onlyWithAchievements = false, bool getHashes = false)
        {
            ConsoleId = consoleId;
            OnlyWithAchievements = onlyWithAchievements ? 1 : 0;
            GetHashes = getHashes ? 1 : 0;
        }

        /// <summary>
        /// TODO:
        /// </summary>
        [ApiInputKey("i")]
        public int ConsoleId { get; init; }

        /// <summary>
        /// TODO:
        /// </summary>
        [ApiInputKey("f")]
        public int OnlyWithAchievements { get; init; }

        /// <summary>
        /// TODO:
        /// </summary>
        [ApiInputKey("h")]
        public int GetHashes { get; init; }
    }
}
