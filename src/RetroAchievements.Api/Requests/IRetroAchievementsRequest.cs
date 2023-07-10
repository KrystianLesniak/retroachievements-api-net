using RetroAchievements.Api.Response;

namespace RetroAchievements.Api.Request
{
    public interface IRetroAchievementsRequest<TResponse> where TResponse : RetroAchievementsResponse
    {
        string RequestEndpoint { get; }
    }
}
