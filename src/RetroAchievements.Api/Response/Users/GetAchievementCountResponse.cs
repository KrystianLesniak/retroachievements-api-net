using System.Net;
using System.Text.Json;

namespace RetroAchievements.Api.Response.Users
{
    public class GetAchievementCountResponse : ResponseBase
    {
        internal GetAchievementCountResponse(string jsonString, HttpStatusCode statusCode) : base(jsonString, statusCode)
        {
            if (IsSuccess)
            {
                GameId = JsonElement.GetProperty("GameID").GetInt32();
                AchievementIds = JsonElement.GetProperty("AchievementIDs").Deserialize<IEnumerable<int>>() ?? new List<int>();
            }
            else
            {
                AchievementIds = new List<int>();
            }
        }

        public int GameId { get; private set; }
        public IEnumerable<int> AchievementIds { get; private set; }


    }
}
