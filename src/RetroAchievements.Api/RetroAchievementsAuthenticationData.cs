namespace RetroAchievements.Api
{
    /// <inheritdoc cref="IRetroAchievementsAuthenticationData"/>
    public record RetroAchievementsAuthenticationData(
        string UserName,
        string WebApiKey
        ) : IRetroAchievementsAuthenticationData;

    /// <summary>
    /// RetroAchievements authentication data required for API calls.
    /// </summary>
    public interface IRetroAchievementsAuthenticationData
    {
        /// <summary>
        /// Username of RetroAchievements Web API Key.
        /// </summary>
        string UserName { get; init; }

        /// <summary>
        /// Secret RetroAchievements Web API Key.
        /// </summary>
        /// <remarks>
        /// Can be obtained in <see href="https://retroachievements.org/controlpanel.php"> control panel</see>
        /// </remarks>
        string WebApiKey { get; init; }
    }
}
