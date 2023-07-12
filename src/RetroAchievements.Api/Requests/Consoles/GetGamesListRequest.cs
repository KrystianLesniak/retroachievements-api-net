using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Consoles;

namespace RetroAchievements.Api.Requests.Consoles
{
    public record GetGamesListRequest : IRetroAchievementsRequest<GetGamesListResponse>
    {
        /// <inheritdoc />
        public string RequestEndpoint => "API_GetGameList";

        ///<inheritdoc cref="GetGamesListRequest" />
        ///<param name="consoleId"><inheritdoc cref="ConsoleId" path="/summary/node()"/></param>
        ///<param name="onlyWithAchievements"><inheritdoc cref="OnlyWithAchievements" path="/summary/node()"/></param>
        ///<param name="getHashes"><inheritdoc cref="GetHashes" path="/summary/node()"/></param>
        public GetGamesListRequest(int consoleId, bool onlyWithAchievements = false, bool getHashes = false)
        {
            ConsoleId = consoleId;
            OnlyWithAchievements = onlyWithAchievements ? 1 : 0;
            GetHashes = getHashes ? 1 : 0;
        }

        [ApiInputKey("i")]
        public int ConsoleId { get; init; }

        [ApiInputKey("f")]
        public int OnlyWithAchievements { get; init; }

        [ApiInputKey("h")]
        public int GetHashes { get; init; }
    }
}
