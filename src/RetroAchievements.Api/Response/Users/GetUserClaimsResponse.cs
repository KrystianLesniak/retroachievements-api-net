using RetroAchievements.Api.Response.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Collection of claims specified for the user.
    /// </summary>
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<Claim, GetUserClaimsResponse>))]
    public record GetUserClaimsResponse : CollectionRetroAchievementsResponse<Claim>
    {
    }
}
