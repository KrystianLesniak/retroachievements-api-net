using RetroAchievements.Api.Response.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Collection of Claims set data.
    /// </summary>

    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<Claim, GetClaimsResponse>))]
    public record GetClaimsResponse : CollectionRetroAchievementsResponse<Claim>
    {
    }
}
