using RetroAchievements.Api.Request;
using RetroAchievements.Api.Response;

namespace RetroAchievements.Api.Internal.Calls
{
    internal interface ICall<TRequest, TResponse> where TResponse : IResponse where TRequest : IRequest
    {
        string ApiUrl { get; set; }

        Task<TResponse> Call(RetroAchievementsClient client, RetroAchievementsAuthenticationData authenticationData, TRequest request);
    }
}
