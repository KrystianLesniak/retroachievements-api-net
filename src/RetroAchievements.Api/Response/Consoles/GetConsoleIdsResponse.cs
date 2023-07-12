using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Consoles;


/// <summary>
/// Data collection of known consoles.
/// </summary>
[JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<Records.Console, GetConsoleIdsResponse>))]
public record GetConsoleIdsResponse : CollectionRetroAchievementsResponse<Records.Console>
{
}
