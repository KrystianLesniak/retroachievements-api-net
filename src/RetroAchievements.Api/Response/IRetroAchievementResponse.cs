using System.Net;

namespace RetroAchievements.Api.Response
{
    public interface IRetroAchievementResponse
    {
        HttpStatusCode StatusCode { get; }
        string? FailedStatusResponseString { get; }
    }
}
