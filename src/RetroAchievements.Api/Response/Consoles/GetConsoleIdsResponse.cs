using RetroAchievements.Api.Response.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Consoles;


[JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<Records.Console, GetConsoleIdsResponse>))]
public record GetConsoleIdsResponse : CollectionRetroAchievementsResponse<Records.Console>
{
}
