using RetroAchievements.Api.Internal.Json.Converters;
using RetroAchievements.Api.Response.Games.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games
{
    public record GetGameExtendedResponse : RetroAchievementsResponse
    {
        [JsonInclude]
        [JsonPropertyName("ID")]
        public int Id { get; private set; }

        [JsonInclude]
        public string Title { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonPropertyName("ConsoleID")]
        public int ConsoleId { get; private set; }

        [JsonInclude]
        public string ConsoleName { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonPropertyName("ParentGameID")]
        public int? ParentGameId { get; private set; }

        [JsonInclude]
        public int NumDistinctPlayersCasual { get; private set; }

        [JsonInclude]
        public int NumDistinctPlayersHardcore { get; private set; }

        [JsonInclude]
        public int NumAchievements { get; private set; }

        [JsonInclude]
        public IDictionary<int, GameAchievement> Achievements { get; private set; } = new Dictionary<int, GameAchievement>();

        [JsonInclude]
        [JsonPropertyName("ForumTopicID")]
        public int ForumTopicId { get; private set; }

        [JsonInclude]
        public string ImageIcon { get; private set; } = string.Empty;

        [JsonInclude]
        public string ImageTitle { get; private set; } = string.Empty;

        [JsonInclude]
        public string ImageIngame { get; private set; } = string.Empty;

        [JsonInclude]
        public string ImageBoxArt { get; private set; } = string.Empty;

        [JsonInclude]
        public string Publisher { get; private set; } = string.Empty;

        [JsonInclude]
        public string Developer { get; private set; } = string.Empty;

        [JsonInclude]
        public string Genre { get; private set; } = string.Empty;

        [JsonInclude]
        [JsonConverter(typeof(DateTimeCustomApiFormatConverter))]
        public DateTime Released { get; private set; }

        [JsonInclude]
        [JsonConverter(typeof(NumberApiToBooleanConverter))]
        public bool IsFinal { get; private set; }

        [JsonInclude]
        public string RichPresencePatch { get; private set; } = string.Empty;

        [JsonInclude]
        public IEnumerable<GameClaim> Claims { get; private set; } = new List<GameClaim>();
    }
}
