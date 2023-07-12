using RetroAchievements.Api.Response;

namespace RetroAchievements.Api.Request
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    public interface IRetroAchievementsRequest<TResponse> where TResponse : RetroAchievementsResponse
    {
        ///<summary>API Endpoint query</summary>
        string RequestEndpoint { get; }
    }

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

}
