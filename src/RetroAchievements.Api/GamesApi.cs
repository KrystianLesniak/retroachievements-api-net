using RetroAchievements.Api.Requests.Games;
using RetroAchievements.Api.Response.Games;

namespace RetroAchievements.Api
{
    public static class GamesApi
    {
        #region GetAchievementCount
        /// <inheritdoc cref="GetAchievementIdentifiersRequest(int)"/>
        public static async Task<GetAchievementIdentifiersResponse> GetAchievementIdentifiersAsync(this RetroAchievementsHttpClient client, int gameId, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetAchievementIdentifiersRequest(gameId), authenticationData);
        }

        /// <inheritdoc cref="GetAchievementIdentifiersRequest(int)"/>
        public static GetAchievementIdentifiersResponse GetAchievementIdentifiers(this RetroAchievementsHttpClient client, int gameId, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetAchievementIdentifiersRequest(gameId), authenticationData);
        }
        #endregion GetAchievementCount

        #region GetAchievementDistribution
        /// <inheritdoc cref="GetAchievementDistributionRequest(int, bool, bool)"/>
        public static async Task<GetAchievementDistributionResponse> GetAchievementDistributionAsync(this RetroAchievementsHttpClient client, int gameId, bool hardcoreOnly = false, bool unofficialAchievements = false, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetAchievementDistributionRequest(gameId, hardcoreOnly, unofficialAchievements), authenticationData);
        }

        /// <inheritdoc cref="GetAchievementDistributionRequest(int, bool, bool)"/>
        public static GetAchievementDistributionResponse GetAchievementDistribution(this RetroAchievementsHttpClient client, int gameId, bool hardcoreOnly = false, bool unofficialAchievements = false, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetAchievementDistributionRequest(gameId, hardcoreOnly, unofficialAchievements), authenticationData);
        }
        #endregion GetAchievementDistribution

        #region GetGame
        public static async Task<GetGameResponse> GetGameAsync(this RetroAchievementsHttpClient client, int gameId, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetGameRequest(gameId), authenticationData);
        }
        public static GetGameResponse GetGame(this RetroAchievementsHttpClient client, int gameId, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGameRequest(gameId), authenticationData);
        }
        #endregion GetGame

        #region GetGameExtended
        public static async Task<GetGameExtendedResponse> GetGameExtendedAsync(this RetroAchievementsHttpClient client, int gameId, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetGameExtendedRequest(gameId), authenticationData);
        }
        public static GetGameExtendedResponse GetGameExtended(this RetroAchievementsHttpClient client, int gameId, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGameExtendedRequest(gameId), authenticationData);
        }
        #endregion GetGameExtended

        #region GetGameRankAndScore
        public static async Task<GetGameRankAndScoreResponse> GetGameRankAndScoreAsync(this RetroAchievementsHttpClient client, int gameId, RankType rankType = RankType.HighScores, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetGameRankAndScoreRequest(gameId, rankType), authenticationData);
        }
        public static GetGameRankAndScoreResponse GetGameRankAndScore(this RetroAchievementsHttpClient client, int gameId, RankType rankType = RankType.HighScores, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGameRankAndScoreRequest(gameId, rankType), authenticationData);
        }
        #endregion GetGameRankAndScore

        #region GetGameRating
        public static async Task<GetGameRatingResponse> GetGameRatingAsync(this RetroAchievementsHttpClient client, int gameId, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return await client.SendAsync(new GetGameRatingRequest(gameId), authenticationData);
        }
        public static GetGameRatingResponse GetGameRating(this RetroAchievementsHttpClient client, int gameId, RetroAchievementsAuthenticationData? authenticationData = null)
        {
            return client.Send(new GetGameRatingRequest(gameId), authenticationData);
        }
        #endregion GetGameRating
    }
}
