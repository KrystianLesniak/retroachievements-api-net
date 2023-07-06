using System.Net;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    public record BaseRetroAchievementsResponse : IRetroAchievementResponse
    {
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; internal set; }

        [JsonIgnore]
        public string? FailedStatusResponseString { get; private set; }

        internal static BaseRetroAchievementsResponse Create(string? responseString, HttpStatusCode statusCode)
        {
            return new()
            {
                FailedStatusResponseString = responseString,
                StatusCode = statusCode
            };
        }

    }
}
