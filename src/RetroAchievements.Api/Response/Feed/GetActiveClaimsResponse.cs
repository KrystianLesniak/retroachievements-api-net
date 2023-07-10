using RetroAchievements.Api.Response.Common;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{

    [JsonConverter(typeof(CollectionRetroAchievementsResponseConverter<Claim, GetActiveClaimsResponse>))]
    public record GetActiveClaimsResponse : CollectionRetroAchievementsResponse<Claim>
    {
    }
}
