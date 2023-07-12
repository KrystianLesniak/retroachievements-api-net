using RetroAchievements.Api.Response.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Collection of data about active set claims.
    /// </summary>
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<Claim, GetActiveClaimsResponse>))]
    public record GetActiveClaimsResponse : CollectionRetroAchievementsResponse<Claim>
    {
    }
}
