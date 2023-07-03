namespace RetroAchievements.Api
{
    public record RetroAchievementsAuthenticationData(
        string UserName,
        string WebApiKey
        ) : IRetroAchievementsAuthenticationData;

    public interface IRetroAchievementsAuthenticationData
    {
        string UserName { get; init; }
        string WebApiKey { get; init; }
    }
}
