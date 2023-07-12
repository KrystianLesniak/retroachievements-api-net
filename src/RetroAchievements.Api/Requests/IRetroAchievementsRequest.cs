using RetroAchievements.Api.Response;

namespace RetroAchievements.Api.Request
{
    /// <summary>
    /// RetroAchievements API Request Data
    /// </summary>
    public interface IRetroAchievementsRequest<TResponse> where TResponse : RetroAchievementsResponse
    {
        ///<summary>API Endpoint query</summary>
        string RequestEndpoint { get; }
    }

}
