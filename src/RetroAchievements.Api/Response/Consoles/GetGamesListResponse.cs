using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Consoles;


/// <summary>
/// List of known games for specified console
/// </summary>
[JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<Records.Game, GetGamesListResponse>))]
public record GetGamesListResponse : CollectionRetroAchievementsResponse<Records.Game>
{
}
