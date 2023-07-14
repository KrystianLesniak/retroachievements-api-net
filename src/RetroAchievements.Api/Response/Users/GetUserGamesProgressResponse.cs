using RetroAchievements.Api.Response.Users.Records;
using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Users
{
    /// <summary>
    /// Collection of user games progress.<br />
    /// <see langword="Key" />: Unique identifier of game.
    /// </summary>
    [JsonConverter(typeof(DictionaryRetroAchievementsResponseConverter<int, UserProgress, GetUserGamesProgressResponse>))]
    public record GetUserGamesProgressResponse : DictionaryRetroAchievementsResponse<int, UserProgress>
    {
    }
}
