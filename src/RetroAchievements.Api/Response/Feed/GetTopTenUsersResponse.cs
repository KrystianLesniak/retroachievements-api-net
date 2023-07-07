using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{

    [JsonConverter(typeof(BaseCollectionRetroAchievementsResponseConverter<User, GetTopTenUsersResponse>))]
    public record GetTopTenUsersResponse : BaseCollectionRetroAchievementsResponse<User>
    {
    }

    public record User
    {
        [JsonInclude]
        [JsonPropertyName("1")]
        public string Name { get; private set; } = String.Empty;

        [JsonInclude]
        [JsonPropertyName("2")]
        public int TotalPoints { get; private set; }

        [JsonInclude]
        [JsonPropertyName("3")]
        public int TotalWhitePoints { get; private set; }
    }
}
