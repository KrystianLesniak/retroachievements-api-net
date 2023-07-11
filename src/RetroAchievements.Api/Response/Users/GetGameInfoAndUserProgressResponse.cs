using RetroAchievements.Api.Response.Users.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    //TODO: Test this response after issue is solved: https://github.com/RetroAchievements/retroachievements-api-js/issues/46
    public record GetGameInfoAndUserProgressResponse : RetroAchievementsResponse
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
        public int NumAwardedToUser { get; private set; }

        [JsonInclude]
        public int NumAwardedToUserHardcore { get; private set; }

        [JsonInclude]
        public IDictionary<string, Achievement> Achievements { get; private set; } = new Dictionary<string, Achievement>();

        [JsonInclude]
        public int ForumTopicID { get; private set; }

        [JsonInclude]
        public int Flags { get; private set; }

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
        public string Released { get; private set; } = string.Empty;

        [JsonInclude]
        public bool IsFinal { get; private set; }

        [JsonInclude]
        public string RichPresencePatch { get; private set; } = string.Empty;
    }
}
