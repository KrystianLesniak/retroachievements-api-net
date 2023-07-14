using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games
{
    /// <summary>
    /// Overall data about rating of the game.
    /// </summary>
    public record GetGameRatingResponse : RetroAchievementsResponse
    {
        /// <summary>
        /// Unique identifier of the game
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("GameID")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int GameId { get; private set; }

        /// <summary>
        /// Rating data of the game.
        /// </summary>
        [JsonInclude]
        public GameRatings Ratings { get; private set; } = new GameRatings();
    }

    /// <summary>
    /// Rating data of the game.
    /// </summary>
    public record GameRatings
    {
        /// <summary>
        /// Average rating of the game.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("Game")]
        public double AverageGameRating { get; private set; }

        /// <summary>
        /// Count of votes contributing to the game's rating.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("GameNumVotes")]
        public int GameVotesCount { get; private set; }
    }
}
