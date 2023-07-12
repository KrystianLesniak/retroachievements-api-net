using RetroAchievements.Api.Response.Users.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<Game, GetUserAllGamesProgressResponse>))]
    public record GetUserAllGamesProgressResponse : CollectionRetroAchievementsResponse<Game>
    {
    }
}
