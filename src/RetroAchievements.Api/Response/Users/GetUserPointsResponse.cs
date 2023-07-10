using RetroAchievements.Api.Response.Users.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    public record GetUserPointsResponse : RetroAchievementsResponse
    {
        [JsonInclude]
        [JsonPropertyName("Points")]
        public int HardcorePoints { get; private set; }

        [JsonInclude]
        public int SoftcorePoints { get; private set; }

    }
}
