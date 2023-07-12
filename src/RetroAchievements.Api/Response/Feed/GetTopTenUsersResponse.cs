using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{

    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<User, GetTopTenUsersResponse>))]
    public record GetTopTenUsersResponse : CollectionRetroAchievementsResponse<User>
    {
    }

    public record User
    {
        [JsonInclude]
        [JsonPropertyName("1")]
        public string Username { get; private set; } = String.Empty;

        [JsonInclude]
        [JsonPropertyName("2")]
        public int TotalPoints { get; private set; }

        [JsonInclude]
        [JsonPropertyName("3")]
        public int TotalWhitePoints { get; private set; }
    }
}
