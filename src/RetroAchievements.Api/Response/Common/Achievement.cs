using System.Text.Json;

namespace RetroAchievements.Api.Response.Common
{
    public class Achievement
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Points { get; set; }
        public int TrueRatio { get; set; }
        public string Author { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        internal static Achievement? Deserialize(JsonElement jsonElement)
        {
            return jsonElement.Deserialize<Achievement>();
        }
    }
}
