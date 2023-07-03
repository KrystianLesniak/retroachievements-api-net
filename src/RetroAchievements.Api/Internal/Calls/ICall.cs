using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response;

namespace RetroAchievements.Api.Internal.Calls
{
    internal interface ICall<TResponse> where TResponse : IResponse
    {
        string ApiUrl { get; set; }

        Task<TResponse> Call(RetroAchievementsHttpClient client, RetroAchievementsAuthenticationData authenticationData, IRequest request);
    }
}
