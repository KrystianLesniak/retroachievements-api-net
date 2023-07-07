using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Common
{
    public record ForumTopic
    {
        [JsonInclude]
        public int Id { get; private set; }

    }
}
