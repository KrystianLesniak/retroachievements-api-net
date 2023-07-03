using System.Net;
using System.Text.Json;

namespace RetroAchievements.Api.Response.Users
{
    public class GetAchievementCountResponse : ResponseBase
    {
        internal GetAchievementCountResponse(string jsonString, HttpStatusCode statusCode) : base(jsonString, statusCode)
        {
        }

        public int GameId
        {
            get
            {
                return JsonElement.GetProperty("GameID").GetInt32();
            }
        } 

        public IEnumerable<int> AchievementIds {
            get
            {
                return JsonElement.GetProperty("AchievementIDs").Deserialize<IEnumerable<int>>() ?? new List<int>();
            }
          }
        
    }
}
