using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Records
{
    public record ForumTopic
    {
        [JsonInclude]
        public int Id { get; private set; }

    }
}
