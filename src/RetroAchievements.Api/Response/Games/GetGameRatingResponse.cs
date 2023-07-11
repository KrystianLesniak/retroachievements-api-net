using RetroAchievements.Api.Internal.Json.Converters;
using RetroAchievements.Api.Response.Games.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    public record GetGameRatingResponse : RetroAchievementsResponse
    {
        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonPropertyName("GameID")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public int GameId { get; private set; }

        [JsonInclude]
        public IEnumerable<GameRating> Ratings { get; private set; } = new List<GameRating>();
    }
}
