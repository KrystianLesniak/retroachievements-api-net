using System.Net;

namespace RetroAchievements.Api.Response
{
    /// <summary>
    /// RetroAchievements API Response Data
    /// </summary>
    public interface IRetroAchievementResponse
    {
        /// <summary>
        /// HTTP Status Code that was return from RetroAchievements API call.
        /// </summary>
        HttpStatusCode HttpStatusCode { get; }
        /// <summary>
        /// In case of <see cref="HttpStatusCode"/> != 200.OK and Deserialization exception this property will contain content returned from RetroAchievements API Call.
        /// </summary>
        string? FailedResponseString { get; }
    }
}
