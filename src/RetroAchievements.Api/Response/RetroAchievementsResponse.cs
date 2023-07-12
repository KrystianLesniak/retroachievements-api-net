using System.Net;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response
{
    /// <inheritdoc cref="IRetroAchievementResponse"/>
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

        /// <inheritdoc />
        [JsonIgnore]
        public HttpStatusCode HttpStatusCode { get; internal set; }

        /// <inheritdoc />
        [JsonIgnore]
        public string? FailedStatusResponseString { get; internal set; }
    }
}
