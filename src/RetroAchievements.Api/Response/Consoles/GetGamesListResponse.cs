using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Consoles;


[JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<Records.Game, GetGamesListResponse>))]
public record GetGamesListResponse : CollectionRetroAchievementsResponse<Records.Game>
{
}
