using System.Text.Json.Serialization;
using RetroAchievements.Api.Response.Common;

namespace RetroAchievements.Api.Response.Users
{

    [JsonConverter(typeof(BaseCollectionRetroAchievementsResponseConverter<Claim, GetClaimsResponse>))]
    public record GetClaimsResponse : BaseCollectionRetroAchievementsResponse<Claim>
    {
    }
}
