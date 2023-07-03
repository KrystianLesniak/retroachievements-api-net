using System.Net;
using System.Text.Json;
using RetroAchievements.Api.Response.Common;

namespace RetroAchievements.Api.Response.Users
{
    public class GetAchievementOfTheWeekResponse : ResponseBase
    {
        internal GetAchievementOfTheWeekResponse(string jsonString, HttpStatusCode statusCode) : base(jsonString, statusCode)
        {
            if (IsSuccess)
            {
                Achievement = Achievement.Deserialize(JsonElement.GetProperty("Achievement")) ?? new ();
            }
            else
            {
                Achievement = new();
            }
        }

        public Achievement Achievement { get; private set; }
    }
}
