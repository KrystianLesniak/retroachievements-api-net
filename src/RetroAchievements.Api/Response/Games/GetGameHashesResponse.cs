using System.Text.Json.Serialization;

namespace RetroAchievements.Api.Response.Games
{
    /// <summary>
    /// Collection of hashes linked to the game.
    /// </summary>
    public record GetGameHashesResponse : RetroAchievementsResponse
    {
        /// <summary>
        /// Collection of hashes linked to the game.
        /// </summary>
        [JsonInclude]
        public IReadOnlyCollection<GameHash> Results { get; private set; } = Array.Empty<GameHash>();
    }

    /// <summary>
    /// Data about the game hash.
    /// </summary>
    public record GameHash
    {
        /// <summary>
        /// MD5 hash.
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("MD5")]
        public string Md5 { get; private set; } = string.Empty;

        /// <summary>
        /// Name of the file (ROM) associated with the hash.
        /// </summary>
        [JsonInclude]
        public string Name { get; private set; } = string.Empty;

        /// <summary>
        /// Labels (sources/regions) associated with the hash.
        /// </summary>
        [JsonInclude]
        public IReadOnlyCollection<string> Labels { get; private set; } = Array.Empty<string>();

        /// <summary>
        /// URL to the patch required for the hash, if any.
        /// </summary>
        [JsonInclude]
        public string? PatchUrl { get; private set; }
    }
}
