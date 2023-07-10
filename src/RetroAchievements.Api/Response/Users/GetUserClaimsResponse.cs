using RetroAchievements.Api.Response.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<Claim, GetUserClaimsResponse>))]
    public record GetUserClaimsResponse : CollectionRetroAchievementsResponse<Claim>
    {
    }
}
