using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games
{
    public record GetGameRatingResponse : RetroAchievementsResponse
    {
        [JsonInclude]
        [JsonPropertyName("GameID")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int GameId { get; private set; }

        [JsonInclude]
        public GameRatings Ratings { get; private set; } = new GameRatings();
    }

    public record GameRatings
    {
        [JsonInclude]
        [JsonPropertyName("Game")]
        public double AverageGameRating { get; private set; }

        [JsonInclude]
        [JsonPropertyName("Achievements")]
        public double AverageAchievementsRating { get; private set; }

        [JsonInclude]
        [JsonPropertyName("GameNumVotes")]
        public int GameVotesCount { get; private set; }

        [JsonInclude]
        [JsonPropertyName("AchievementsNumVotes")]
        public int AchievementVotesCount { get; private set; }
    }
}
