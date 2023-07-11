using RetroAchievements.Api.Response.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Consoles;


[JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<Records.Game, GetGameListResponse>))]
public record GetGameListResponse : CollectionRetroAchievementsResponse<Records.Game>
{
}
