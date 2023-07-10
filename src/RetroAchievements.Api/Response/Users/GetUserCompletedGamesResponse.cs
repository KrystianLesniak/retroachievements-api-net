using RetroAchievements.Api.Response.Users.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<Game, GetUserCompletedGamesResponse>))]
    public record GetUserCompletedGamesResponse : CollectionRetroAchievementsResponse<Game>
    {
    }
}
