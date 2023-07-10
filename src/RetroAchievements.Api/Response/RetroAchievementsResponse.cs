using System.Net;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response
{
    public record RetroAchievementsResponse : IRetroAchievementResponse
    {
        internal RetroAchievementsResponse()
        {
        }

        internal RetroAchievementsResponse(HttpStatusCode statusCode, string? failedStatusResponseString)
        {
            StatusCode = statusCode;
            FailedStatusResponseString = failedStatusResponseString;
        }

        [JsonIgnore]
        public HttpStatusCode StatusCode { get; internal set; }

        [JsonIgnore]
        public string? FailedStatusResponseString { get; internal set; }
    }
}
