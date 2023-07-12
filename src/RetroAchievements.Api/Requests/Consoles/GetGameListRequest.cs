using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response.Consoles;

namespace RetroAchievements.Api.Requests.Consoles
{
    public record GetGameListRequest : IRetroAchievementsRequest<GetGameListResponse>
    {
        public string RequestEndpoint => "API_GetGameList";

        public GetGameListRequest(int consoleId, bool onlyWithAchievements = false, bool getHashes = false)
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
