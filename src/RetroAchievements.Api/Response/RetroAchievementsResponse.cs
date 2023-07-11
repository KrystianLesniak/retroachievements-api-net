using System.Net;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response
{
    public record RetroAchievementsResponse : IRetroAchievementResponse
    {
        internal RetroAchievementsResponse()
        {
        }

        internal RetroAchievementsResponse(HttpStatusCode httpStatusCode, string? failedStatusResponseString)
        {
            HttpStatusCode = httpStatusCode;
            FailedStatusResponseString = failedStatusResponseString;
        }

        [JsonIgnore]
        public HttpStatusCode HttpStatusCode { get; internal set; }

        [JsonIgnore]
        public string? FailedStatusResponseString { get; internal set; }
    }
}
