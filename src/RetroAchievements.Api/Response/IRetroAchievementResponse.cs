using System.Net;

namespace RetroAchievements.Api.Response
{
    public interface IRetroAchievementResponse
    {
        HttpStatusCode HttpStatusCode { get; }
        string? FailedStatusResponseString { get; }
    }
}
